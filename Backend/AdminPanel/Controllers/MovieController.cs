using Buisness.Abstract;
using DataAccess.Concret;
using Entities.Models;
using Entity.Params;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;
        private readonly ILanguageService _languageService;
        private readonly IMovieDetailService _movieDetailService;



        public MovieController(IMovieService movieService, ILanguageService languageService, IMovieDetailService movieDetailService) 
        {
            _movieService = movieService;
            _languageService = languageService;
            _movieDetailService = movieDetailService;

        }

        #region Index
        public async Task<IActionResult> Index()
        {

            var movie = await _movieService.GetAllMovieAsync();

            return View(movie);
        }
        #endregion 

        #region Create
        public async Task<IActionResult> Create()
        {
            ViewBag.Languages = await _languageService.GetAllLanguageAsync();



            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MovieParams movieParams)
        {
            ViewBag.Languages = await _languageService.GetAllLanguageAsync();
            if (!ModelState.IsValid)
            {
                return View();
            }

            var isExist = await _movieService.MovieAnyAsync(x => x.Name.ToLower() == movieParams.Name);
            if (isExist )
            {
                ModelState.AddModelError("Name", "Please change the context.Title is already exist !");
                return View();
            }

            if (movieParams.StartTime > movieParams.EndTime)
            {
                ModelState.AddModelError("EndTime", "The end time cannot come before the start time !");
                return View();
            }

            if (movieParams.Age >= 168)
            {
                ModelState.AddModelError("Age", "Not everyone can be Shirali baba !");
                return View();
            }


            await _movieService.AddMovieAsync(movieParams);

            return RedirectToAction("Index");
        }
        #endregion

        #region Detail
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
                return NotFound();

            ViewBag.Languages = await _languageService.GetAllLanguageAsync();

            var movie = await _movieService.GetMovieWithIdAsync((int)id);


            if (movie == null)
                return NotFound();

            var movieDetail = await _movieDetailService.GetMovieDetailWithIdAsync(movie.Id);

            if (movieDetail == null)
                return NotFound();

            MovieParams movieParams = new()
            {
                
                Genre = movieDetail.Genre,
                About = movieDetail.About,
                Actors = movieDetail.Actors,
                Country = movieDetail.Country,
                Director = movieDetail.Director,
                Duration = movieDetail.Duration,
                Treyler = movieDetail.Treyler,
                Age = movie.Age,
                Name = movie.Name,
                Image = movie.Image,
                EndTime = movie.EndTime,
                StartTime = movie.StartTime,
                LanguageName = movie.Language.Code


            };
            return View(movieParams);
        }
        #endregion

        #region Update
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
                return NotFound();

            ViewBag.Languages = await _languageService.GetAllLanguageAsync();

            var movie = await _movieService.GetMovieWithIdAsync((int)id);


            if (movie == null)
                return NotFound();

            var movieDetail = await _movieDetailService.GetMovieDetailWithIdAsync(movie.Id);

            if (movieDetail == null)
                return NotFound();

            MovieParams movieParams = new()
            {
                Treyler = movieDetail.Treyler,
                Duration = movieDetail.Duration,
                Genre = movieDetail.Genre,
                About = movieDetail.About,
                Actors = movieDetail.Actors,
                Country = movieDetail.Country,
                Director = movieDetail.Director,
                Age = movie.Age,
                Name = movie.Name,
                Image = movie.Image,
                StartTime = movie.StartTime,
                EndTime = movie.EndTime,
                LanguageId =movie.LanguageId,
                MovieDetailId = movieDetail.Id,
                MovieId = movie.Id

            };
            return View(movieParams);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(MovieParams movieParams, string oldPhoto)
        {
            if (!ModelState.IsValid)
            {
                return View(movieParams);
            }
            ViewBag.Languages = await _languageService.GetAllLanguageAsync();
            
          var isMovieUpdatedData = await _movieService.UpdateMovieAsync(movieParams, oldPhoto);

            if(isMovieUpdatedData == false)
            {
                // shekilsiz yuklemek olmaz!!!!
            }

            return RedirectToAction("Index");


        }
        #endregion

        #region Delete
        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteMovie(int? id)
        {
            if (id == null)
                return NotFound();

            var movie = await _movieService.GetMovieWithIdAsync(id.Value);
            if (movie == null)
                return NotFound();


            await _movieService.DeleteMovieAsync(id.Value);

            return RedirectToAction("Index");
        }
        #endregion

    }
}
