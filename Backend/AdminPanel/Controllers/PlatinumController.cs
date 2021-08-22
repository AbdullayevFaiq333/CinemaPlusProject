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
        private readonly ILanguageService _languageService;

        public PlatinumController(IPlatiniumService platiniumService,ILanguageService languageService)
        {
            _platiniumService = platiniumService;
            _languageService = languageService;
        }
        public async Task<IActionResult> Index()
        {

            var platinum = await _platiniumService.GetAllPlatiniumAsync();

            return View(platinum);

        }
        public async Task<IActionResult> Create()
        {

            ViewBag.Languages = await _languageService.GetAllLanguageAsync();

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
                ModelState.AddModelError("Title", "Please change the context.Title is already exist !");
                return View();
            }
            platinium.IsDeleted = false;
            await _platiniumService.AddPlatiniumAsync(platinium);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var platinum = await _platiniumService.GetPlatiniumWithIdAsync(id.Value);


            ViewBag.Languages = await _languageService.GetAllLanguageAsync();

            if (platinum == null)
                return NotFound();

            return View(platinum);
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
                return NotFound();

            var platinum = await _platiniumService.GetPlatiniumWithIdAsync(id.Value);


            ViewBag.Languages = await _languageService.GetAllLanguageAsync();



            if (platinum == null)
                return NotFound();

            return View(platinum);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]

        //public async Task<IActionResult> Update(int? id, Platinium platinium)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View();
        //    }

        //    if (id == null)
        //        return NotFound();

        //    if (id != platinium.Id)
        //        return BadRequest();

        //    var dBplatinum = await _platiniumService.PlatinumAnyAsync();
        //    if (dBplatinum == null)
        //        return NotFound();

        //    var isExist = await _platiniumService.PlatinumAnyAsync(x => x.Title.ToLower() == platinium.Title);

        //    if (isExist)
        //    {
        //        ModelState.AddModelError("Title", "Please change the context.Title is already exist !");
        //        return View();
        //    }

        //    dBplatinum.Language = platinium.Language;
        //    dBplatinum.Title = platinium.Title;
        //    dBplatinum.Description = platinium.Description;

        //    return RedirectToAction("Index");


        //}



         
        [HttpGet]
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
