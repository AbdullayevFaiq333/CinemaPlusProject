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

        public AboutUsHeadPartController(IAboutUsHeadPartService aboutUsHeadPartService)
        {
            _AboutUsHeadPartService = aboutUsHeadPartService;
        }
        public async Task<IActionResult> Index()
        {

            var AboutUsHeadPart = await _AboutUsHeadPartService.GetAllAboutUsHeadPartAsync();

            return View(AboutUsHeadPart);
        }
    }
}
