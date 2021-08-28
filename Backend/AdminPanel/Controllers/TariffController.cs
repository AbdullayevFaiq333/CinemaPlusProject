using Buisness.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Controllers
{
    public class TariffController : Controller
    {
        private readonly ITariffService _tariffService;

        public TariffController(ITariffService tariffService)
        {
            _tariffService = tariffService;
        }

        #region Index
        public async Task<IActionResult> Index()
        {

            var tariff = await _tariffService.GetAllTariffAsync();

            return View(tariff);
        }
        #endregion
    }
}
