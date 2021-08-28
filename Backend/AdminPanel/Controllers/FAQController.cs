using Buisness.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Controllers
{
    public class FAQController : Controller
    {
        private readonly IFAQService _FAQService;

        public FAQController(IFAQService FAQService)
        {
            _FAQService = FAQService;
        }
        #region Index
        public async Task<IActionResult> Index()
        {

            var FAQ = await _FAQService.GetAllFAQAsync();

            return View(FAQ);
        }
        #endregion
    }
}
