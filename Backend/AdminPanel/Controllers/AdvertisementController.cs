using Buisness.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 

namespace AdminPanel.Controllers
{
    public class AdvertisementController : Controller
    {
        private readonly IAdvertisementService _advertisementService;
        private readonly ILanguageService _languageService;


        public AdvertisementController(IAdvertisementService advertisementService, ILanguageService languageService)
        {
            _advertisementService = advertisementService;
            _languageService = languageService;

        }
        public async Task<IActionResult> Index()
        {

            var advertisement = await _advertisementService.GetAllAdvertisementAsync();

            return View(advertisement);
        }
        public async Task<IActionResult> Create()
        {

            ViewBag.Languages = await _languageService.GetAllLanguageAsync();

            return View();
        }
    }
}
