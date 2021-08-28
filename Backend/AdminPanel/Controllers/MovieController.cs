using Buisness.Abstract;
using DataAccess.Concret;
using Entities.Models;
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


        public MovieController(IMovieService movieService, ILanguageService languageService) 
        {
            _movieService = movieService;
            _languageService = languageService;

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
        public async Task<IActionResult> Create(Movie movie)
        { 
            if (!ModelState.IsValid)
            {
                return View();
            }

            var isExist = await _movieService.MovieAnyAsync(x => x.Name.ToLower() == movie.Name);
            if (isExist)
            {
                ModelState.AddModelError("Name", "Please change the context.Title is already exist !");
                return View();
            }

            await _movieService.AddMovieAsync(movie);

            return RedirectToAction("Index");
        }
        #endregion

        #region Detail
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var movieDetail = await _movieService.GetMovieDetail(id);

            

            ViewBag.Languages = await _languageService.GetAllLanguageAsync();

            if (movieDetail == null)
                return NotFound();

            return View(movieDetail);
        }
        #endregion

        #region Update
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
                return NotFound();

            var movie = await _movieService.GetMovieWithIdAsync(id.Value);


            ViewBag.Languages = await _languageService.GetAllLanguageAsync();




            if (movie == null)
                return NotFound();

            return View(movie);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(Movie movie,string oldPhoto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var isExist = await _movieService.MovieAnyAsync(x => x.Name.ToLower() == movie.Name);
            if (isExist)
            {
                ModelState.AddModelError("Name", "Please change the context.Title is already exist !");
                return View();
            }
          var isMovieUpdatedData = await _movieService.UpdateMovieAsync(movie,oldPhoto);

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


            await _movieService.DeleteMovieAsync(movie);

            return RedirectToAction("Index");
        }
        #endregion

    }
}
