using Buisness.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Controllers
{
    public class SeatController : Controller
    {
        private readonly ISeatService _seatService;

        public SeatController(ISeatService seatService)
        {
            _seatService = seatService;
        }

        #region Index
        public async Task<IActionResult> Index()
        {

            var seat = await _seatService.GetAllSeatAsync();

            return View(seat);
        }
        #endregion
    }
}
