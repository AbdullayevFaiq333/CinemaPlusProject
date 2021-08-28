using Buisness.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Controllers
{
    public class FooterController : Controller
    {
        private readonly IFooterService _footerService;

        public FooterController(IFooterService footerService)
        {
            _footerService = footerService;
        }

        #region Index
        public async Task<IActionResult> Index()
        {

            var footer = await _footerService.GetAllFooterAsync();

            return View(footer);
        }
        #endregion
    }
}
