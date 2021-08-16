using Buisness.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Controllers
{
    public class SecondFooterController : Controller
    {
        private readonly ISecondFooterService _secondFooterService;

        public SecondFooterController(ISecondFooterService secondFooterService)
        {
            _secondFooterService = secondFooterService;
        }
        public async Task<IActionResult> Index()
        {

            var secondFooter = await _secondFooterService.GetAllSecondFooterAsync();

            return View(secondFooter);
        }
    }
}
