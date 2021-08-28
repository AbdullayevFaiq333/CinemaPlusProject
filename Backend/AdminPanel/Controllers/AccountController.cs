using AdminPanel.Utils;
using DataAccess.Identity;
using Entity.Entities;
using Entity.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;


        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }



        public  IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]


        public async Task<IActionResult> Login(LoginViewModel login)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var existUser = await _userManager.FindByEmailAsync(login.Email);
            if (existUser == null)
            {
                ModelState.AddModelError("", "Email or Password is INCORRECT");
                return View();
            }

            var loginResult = await _signInManager.PasswordSignInAsync(existUser, login.Passsword, login.RememberMe, true);
            if (!loginResult.Succeeded)
            {
                ModelState.AddModelError("", "Email or Password is INCORRECT");
                return View();
            }
            if (loginResult.IsLockedOut)
            {
                ModelState.AddModelError("", "Your account is locked out.Try a few minut later !");
                return View();
            }


            return RedirectToAction("Index", "Home");

        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel register)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }

            var dbUser = await _userManager.FindByNameAsync(register.Fullname);
            if (dbUser != null)
            {
                ModelState.AddModelError("Username", "This User is already exist !");
                return View();
            }

            var newUser = new User
            {
                UserName = register.Username,
                FullName = register.Fullname,
                Email = register.Email

            };

            var identityResult = await _userManager.CreateAsync(newUser, register.Passsword);
            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }

            await _userManager.AddToRoleAsync(newUser, RoleConstants.ModeratorRole);

            await _signInManager.SignInAsync(newUser, true);

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
        public IActionResult ForgotPassword(string id)
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel forgotPassword)
        {
            if (string.IsNullOrEmpty(forgotPassword.Email))
            {
                ModelState.AddModelError("Email", " Email does not empty");
                return View();
            }

            if (forgotPassword == null)
            {
                return NotFound();
            }
            var user = await _userManager.FindByEmailAsync(forgotPassword.Email);

            if (user == null)
            {
                ModelState.AddModelError("Email", "This account does not exist");
                return View();
            }
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);

            string href = Url.Action("ResetPassword", new { userEmail = forgotPassword.Email, token });

            string url = "https://localhost:44302/" + href;
            string subject = "ResetPassword";
            string msgBody = $"<a href={url}>Click for Reset Password</a> ";
            string mail = forgotPassword.Email;

            await Helper.SendMessage(subject, msgBody, mail);
            TempData["Email"] = forgotPassword.Email;
            TempData["Token"] = token;

            return RedirectToAction("Login");
        }
        public IActionResult ResetPassword(string userEmail, string token)
        {
            if ((string)TempData["Email"] != userEmail || (string)TempData["Token"] != token)
            {
                return BadRequest();
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(string userEmail, string token, ResetPasswordViewModel resetPassword)
        {
            if (string.IsNullOrEmpty(userEmail))
                return NotFound();

            if (!ModelState.IsValid)
            {
                return View();
            }

            var dbUser = await _userManager.FindByEmailAsync(userEmail);
            if (dbUser == null)
            {
                return BadRequest();
            }

            var result = await _userManager.ResetPasswordAsync(dbUser, token, resetPassword.NewPassword);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }
            return RedirectToAction("Login");
        }


    }
}
