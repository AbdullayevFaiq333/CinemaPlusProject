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

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        public async Task<IActionResult> Index()
        {

            var movie = await _movieService.GetAllMovieAsync();

            return View(movie);
        }
        //public IActionResult Create()
        //{
        //    ViewBag.Languages = _dbContext.Languages.ToList();


        //    return View();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create(Movie movies)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View();
        //    }

        //    var isExist = await _dbContext.Movies.AnyAsync(x => x.Name.ToLower() == movies.Name.ToLower());
        //    if (isExist)
        //    {
        //        ModelState.AddModelError("Name", "Please change the context.Name is already exist !");
        //        return View();
        //    }


        //    await _dbContext.Movies.AddAsync(movies);
        //    await _dbContext.SaveChangesAsync();

        //    return RedirectToAction("Index");
        //}
        //public IActionResult Detail(int? id)
        //{
        //    if (id == null)
        //        return NotFound();

        //    var movie = _dbContext.Movies.Find(id);

        //    if (movie == null)
        //        return NotFound();

        //    ViewBag.Languages = _dbContext.Languages.ToList();


        //    return View(movie);
        //}
        //public IActionResult Update(int? id)
        //{
        //    if (id == null)
        //        return NotFound();

        //    var movie = _dbContext.Movies.Find(id);

        //    if (movie == null)
        //        return NotFound();

        //    ViewBag.Languages = _dbContext.Languages.ToList();

        //    return View(movie);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]

        //public async Task<IActionResult> Update(int? id, Movie movies)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View();
        //    }

        //    if (id == null)
        //        return NotFound();

        //    if (id != movies.Id)
        //        return BadRequest();

        //    var movie = await _dbContext.Movies.FindAsync(id);
        //    if (movie == null)
        //        return NotFound();

        //    var isExist = await _dbContext.Movies.AnyAsync(x => x.Name.ToLower() == movie.Name.
        //                                                                         ToLower() && x.Id != id);
        //    if (isExist)
        //    {
        //        ModelState.AddModelError("Name", "Please change the text.Name is already exist !");
        //        return View();
        //    }

        //    //dbMovie.Language = movie.Language;
        //    //dbMovie.Name = movie.Name;
        //    //dbMovie.FirstDescription = movie.Age;
        //    //dbMovie.YoutubeURL = movie.Image;

        //    await _dbContext.SaveChangesAsync();
        //    return RedirectToAction("Index");


        //}

        //[HttpGet]
        //[ActionName("Delete")]
        //public async Task<IActionResult> DeleteMovie(int? id)
        //{
        //    if (id == null)
        //        return NotFound();

        //    var movie = await _dbContext.Movies.FindAsync(id);

        //    if (movie == null)
        //        return NotFound();

        //    //_dbContext.DolbyAtmos.Remove(movie);
        //    await _dbContext.SaveChangesAsync();

        //    return RedirectToAction("Index");
        //}

    }
}
