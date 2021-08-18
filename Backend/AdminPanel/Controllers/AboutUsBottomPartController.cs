using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Buisness.Abstract;
using Entities.Models;

namespace AdminPanel.Controllers
{
    public class AboutUsBottomPartController : Controller 
    {
        private readonly IAboutUsBottomPartService _aboutUsBottomPartService;
        private readonly ILanguageService _languageService;


        public AboutUsBottomPartController (IAboutUsBottomPartService aboutUsBottomPartService, ILanguageService languageService)
        {
            _aboutUsBottomPartService = aboutUsBottomPartService;
            _languageService = languageService;

        }
        public async Task<IActionResult> Index()
        {

            var aboutUsBottomPart = await _aboutUsBottomPartService.GetAllAboutUsBottomPartAsync();

            return View(aboutUsBottomPart);
        }
        public async Task<IActionResult> Create()
        {

            ViewBag.Languages = await _languageService.GetAllLanguageAsync();

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AboutUsBottomPart  aboutUsBottomPart)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var isExist = await _aboutUsBottomPartService.AboutUsBootomPartAnyAsync(x => x.Description.ToLower() == aboutUsBottomPart.Description);
            if (isExist)
            {
                ModelState.AddModelError("FirstTitle", "Please change the context.Title is already exist !");
                return View();
            }
            await _aboutUsBottomPartService.AddAboutUsBottomPartAsync(aboutUsBottomPart);

            return RedirectToAction("Index");
        }
    }
}
