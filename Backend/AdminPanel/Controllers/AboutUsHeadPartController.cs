using Buisness.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Controllers
{
    public class AboutUsHeadPartController : Controller
    {

        private readonly IAboutUsHeadPartService _AboutUsHeadPartService;
        private readonly ILanguageService _languageService;


        public AboutUsHeadPartController(IAboutUsHeadPartService aboutUsHeadPartService, ILanguageService languageService)
        {
            _AboutUsHeadPartService = aboutUsHeadPartService;
            _languageService = languageService;

        }

        #region Index
        public async Task<IActionResult> Index()
        {

            var AboutUsHeadPart = await _AboutUsHeadPartService.GetAllAboutUsHeadPartAsync();

            return View(AboutUsHeadPart);
        }
        #endregion
    }
}
