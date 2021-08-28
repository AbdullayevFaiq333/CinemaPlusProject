using Buisness.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Controllers
{
    public class NavbarController : Controller
    {
        private readonly INavbarService _navbarService;

        public NavbarController(INavbarService navbarService)
        {
            _navbarService = navbarService;
        }
        #region Index
        public async Task<IActionResult> Index()
        {

            var navbar = await _navbarService.GetAllNavbarAsync();

            return View(navbar);
        }
        #endregion
    }
}
