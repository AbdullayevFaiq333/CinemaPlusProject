using Microsoft.AspNetCore.Mvc;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Concret;
using DataAccess;
using Buisness.Abstract;

namespace AdminPanel.Controllers
{
    public class PlatinumController : Controller
    {
        private readonly IPlatiniumService _platiniumService;

        public PlatinumController(IPlatiniumService platiniumService)
        {
            _platiniumService = platiniumService;
        }
        public async Task<IActionResult> Index()
        {

            var platinum = await _platiniumService.GetAllPlatiniumAsync();

            return View(platinum);

        }
        public IActionResult Create()
        {
            //ViewBag.Languages = _dbContext.Languages.ToList();



            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Platinium platinium)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var isExist = await _platiniumService.PlatinumAnyAsync(x => x.Title.ToLower() == platinium.Title);
            if (isExist)
            {
                ModelState.AddModelError("FirstTitle", "Please change the context.Title is already exist !");
                return View();
            }
            await _platiniumService.AddPlatiniumAsync(platinium);

            return RedirectToAction("Index");
        }

        //public IActionResult Detail(int? id)
        //{
        //    if (id == null)
        //        return NotFound();

        //    var platinum = _dbContext.Platiniums.Find(id);

        //    ViewBag.Languages = _dbContext.Languages.ToList();

        //    if (platinum == null)
        //        return NotFound();

        //    return View(platinum);
        //}
        //public IActionResult Update(int? id)
        //{
        //    if (id == null)
        //        return NotFound();

        //    var platinum = _dbContext.Platiniums.Find(id);

        //    ViewBag.Languages = _dbContext.Languages.ToList();


        //    if (platinum == null)
        //        return NotFound();

        //    return View(platinum);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]

        //public async Task<IActionResult> Update(int? id, Platinium platinum)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View();
        //    }

        //    if (id == null)
        //        return NotFound();

        //    if (id != platinum.Id)
        //        return BadRequest();

        //    var dBplatinum = await _dbContext.Platiniums.FindAsync(id);
        //    if (dBplatinum == null)
        //        return NotFound();

        //    var isExist = await _dbContext.Platiniums.AnyAsync(x => x.Title.ToLower() == platinum.Title.
        //                                                                         ToLower() && x.Id != id);
        //    if (isExist)
        //    {
        //        ModelState.AddModelError("Title", "Please change the context.Title is already exist !");
        //        return View();
        //    }

        //    dBplatinum.Language = platinum.Language;
        //    dBplatinum.Title = platinum.Title;
        //    dBplatinum.Description = platinum.Description;

        //    await _dbContext.SaveChangesAsync();
        //    return RedirectToAction("Index");


        //}
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //        return NotFound();

        //    var platinum = await _dbContext.Platiniums.FindAsync(id);

        //    ViewBag.Languages = _dbContext.Languages.ToList();


        //    if (platinum == null)
        //        return NotFound();

        //    return View(platinum);
        //}


        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePlatinum(int? id)
        {
            if (id == null)
                return NotFound();

            var platinum = await _platiniumService.GetPlatiniumWithIdAsync(id.Value);
            if (platinum == null)
                return NotFound();

            platinum.IsDeleted = true;

            await _platiniumService.UpdatePlatiniumAsync(platinum);

            //await _platiniumService.DeletePlatiniumAsync(platinum.Id);

            return RedirectToAction("Index");
        }

    }
}
