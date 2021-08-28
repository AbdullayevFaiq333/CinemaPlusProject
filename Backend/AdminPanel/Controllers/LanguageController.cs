using Buisness.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Controllers
{
    public class LanguageController : Controller
    {
        private readonly ILanguageService _languageService;

        public LanguageController(ILanguageService languageService)
        {
            _languageService = languageService;
        }
        #region Index
        public async Task<IActionResult> Index()
        {

            var language = await _languageService.GetAllLanguageAsync();

            return View(language);
        }
        #endregion
    }
}
