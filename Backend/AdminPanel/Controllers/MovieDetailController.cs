using Buisness.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Controllers
{
    public class MovieDetailController : Controller
    {
        private readonly IMovieDetailService _movieDetailService;

        public MovieDetailController(IMovieDetailService movieDetailService)
        {
            _movieDetailService = movieDetailService;
        }

        #region Index
        public async Task<IActionResult> Index()
        {

            var movieDetail = await _movieDetailService.GetAllMovieDetailAsync();

            return View(movieDetail);
        }
        #endregion
    }
}
