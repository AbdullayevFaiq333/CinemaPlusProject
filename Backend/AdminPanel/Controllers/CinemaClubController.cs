using Buisness.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Controllers
{
    public class CinemaClubController : Controller
    {
        private readonly ICinemaClubService _cinemaClubService;

        public CinemaClubController(ICinemaClubService cinemaClubService)
        {
            _cinemaClubService = cinemaClubService;
        }
        #region Index
        public async Task<IActionResult> Index()
        {

            var cinemaClub = await _cinemaClubService.GetAllCinemaClubAsync();

            return View(cinemaClub);
        }
        #endregion
    }
}
