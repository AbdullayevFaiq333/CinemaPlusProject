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

        public async Task<IActionResult> Index()
        {

            var movie = await _movieService.GetAllMovieAsync();

            return View(movie);
        }
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

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var movie = await _movieService.GetMovieWithIdAsync(id.Value);


            ViewBag.Languages = await _languageService.GetAllLanguageAsync();

            if (movie == null)
                return NotFound();

            return View(movie);
        }


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

        public async Task<IActionResult> Update(int? id, Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (id == null)
                return NotFound();

            if (id != movie.Id)
                return BadRequest();

        

            var isExist = await _movieService.MovieAnyAsync(x => x.Name.ToLower() == movie.Name);

            if (isExist)
            {
                ModelState.AddModelError("Name", "Please change the context.Title is already exist !");
                return View();
            }


            await _movieService.UpdateMovieAsync(movie);
    

            return RedirectToAction("Index");


        }

        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePlatinum(int? id)
        {
            if (id == null)
                return NotFound();

            var movie = await _movieService.GetMovieWithIdAsync(id.Value);
            if (movie == null)
                return NotFound();


            await _movieService.UpdateMovieAsync(movie);

            //await _platiniumService.DeletePlatiniumAsync(platinum.Id);

            return RedirectToAction("Index");
        }


    }
}
