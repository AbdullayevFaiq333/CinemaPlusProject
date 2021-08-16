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
    public class DolbyAtmosController : Controller
    {
        private readonly IDolbyAtmosService _dolbyAtmosService;

        public DolbyAtmosController(IDolbyAtmosService hallService)
        {
            _dolbyAtmosService = hallService;
        }

        public async Task<IActionResult> Index()
        {
            var dolbyAtmos = await _dolbyAtmosService.GetAllDolbyAtmosAsync();


            return View(dolbyAtmos);
        }
        //public IActionResult Create()
        //{
        //    ViewBag.Languages = _dbContext.Languages.ToList();


        //    return View();
        //}

        //[HttpPost] 
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create(DolbyAtmos dolbyAtmos)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View();
        //    }

        //    var isExist = await _dbContext.DolbyAtmos.AnyAsync(x => x.FirstTitle.ToLower() == dolbyAtmos.FirstTitle.ToLower());
        //    if (isExist)
        //    {
        //        ModelState.AddModelError("FirstTitle", "Please change the context.Title is already exist !");
        //        return View();
        //    }


        //    await _dbContext.DolbyAtmos.AddAsync(dolbyAtmos);
        //    await _dbContext.SaveChangesAsync();

        //    return RedirectToAction("Index");
        //}


        //public IActionResult Detail(int? id)
        //{
        //    if (id == null)
        //        return NotFound();

        //    var dolbyAtmos = _dbContext.DolbyAtmos.Find(id);

        //    if (dolbyAtmos == null)
        //        return NotFound();

        //    ViewBag.Languages = _dbContext.Languages.ToList();


        //    return View(dolbyAtmos);
        //}

        //public IActionResult Update(int? id)
        //{
        //    if (id == null)
        //        return NotFound();

        //    var dolbyAtmos = _dbContext.DolbyAtmos.Find(id);

        //    if (dolbyAtmos == null)
        //        return NotFound();

        //    ViewBag.Languages = _dbContext.Languages.ToList();

        //    return View(dolbyAtmos);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]

        //public async Task<IActionResult> Update(int? id, DolbyAtmos dolbyAtmos)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(); 
        //    }

        //    if (id == null)
        //        return NotFound();

        //    if (id != dolbyAtmos.Id)
        //        return BadRequest();

        //    var dbDolbyAtmos = await _dbContext.DolbyAtmos.FindAsync(id);
        //    if (dbDolbyAtmos == null)
        //        return NotFound();

        //    var isExist = await _dbContext.DolbyAtmos.AnyAsync(x => x.FirstTitle.ToLower() == dolbyAtmos.FirstTitle.
        //                                                                         ToLower() && x.Id != id);
        //    if (isExist)
        //    {
        //        ModelState.AddModelError("FirstTitle", "Please change the context.Title is already exist !");
        //        return View();
        //    }

        //    dbDolbyAtmos.Language = dolbyAtmos.Language;
        //    dbDolbyAtmos.FirstTitle = dolbyAtmos.FirstTitle;
        //    dbDolbyAtmos.FirstDescription = dolbyAtmos.FirstDescription;
        //    dbDolbyAtmos.YoutubeURL = dolbyAtmos.YoutubeURL;
        //    dbDolbyAtmos.SecondTitle = dolbyAtmos.SecondTitle;
        //    dbDolbyAtmos.FirstDescription= dolbyAtmos.FirstDescription;

        //    await _dbContext.SaveChangesAsync();
        //    return RedirectToAction("Index");


        //}


        //[HttpGet]
        //[ActionName("Delete")]
        //public async Task<IActionResult> DeleteDolby (int? id)
        //{
        //    if (id == null)
        //        return NotFound();

        //    var dolbyAtmos = await _dbContext.DolbyAtmos.FindAsync(id);

        //    if (dolbyAtmos == null)
        //        return NotFound();

        //    _dbContext.DolbyAtmos.Remove(dolbyAtmos);
        //    await _dbContext.SaveChangesAsync();

        //    return RedirectToAction("Index");
        //}

    }

}
