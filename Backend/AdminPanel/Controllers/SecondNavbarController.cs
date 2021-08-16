using Buisness.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Controllers
{
    public class SecondNavbarController : Controller
    {
        private readonly ISecondNavbarService _secondNavbarService;

        public SecondNavbarController(ISecondNavbarService secondNavbarService)
        {
            _secondNavbarService = secondNavbarService;
        }
        public async Task<IActionResult> Index()
        {

            var secondNavbar = await _secondNavbarService.GetAllSecondNavbarAsync();

            return View(secondNavbar);
        }
    }
}

