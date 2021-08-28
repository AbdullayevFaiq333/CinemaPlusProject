using Buisness.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Controllers
{
    public class MovieFormatController : Controller
    {
        private readonly IMovieFormatService _movieFormatService;

        public MovieFormatController(IMovieFormatService movieFormatService)
        {
            _movieFormatService = movieFormatService;
        }
        #region Index
        public async Task<IActionResult> Index()
        {

            var movieFormat = await _movieFormatService.GetAllMovieFormatAsync();

            return View(movieFormat);
        }
        #endregion
    }
}
