using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Buisness.Abstract;


namespace AdminPanel.Controllers
{
    public class AboutUsBottomPartController : Controller
    {
        private readonly IAboutUsBottomPartService _aboutUsBottomPartService;

        public AboutUsBottomPartController (IAboutUsBottomPartService aboutUsBottomPartService)
        {
            _aboutUsBottomPartService = aboutUsBottomPartService;
        }
        public async Task<IActionResult> Index()
        {

            var aboutUsBottomPart = await _aboutUsBottomPartService.GetAllAboutUsBottomPartAsync();

            return View(aboutUsBottomPart);
        }
    }
}
