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
        private readonly ILanguageService _languageService;

        public DolbyAtmosController(IDolbyAtmosService dolbyAtmosService, ILanguageService languageService)
        {
            _dolbyAtmosService = dolbyAtmosService;
            _languageService = languageService;

        }

        public async Task<IActionResult> Index()
        {
            var dolbyAtmos = await _dolbyAtmosService.GetAllDolbyAtmosAsync();

             
            return View(dolbyAtmos);
        }
        public async Task<IActionResult> Create()
        {
            ViewBag.Languages = await _languageService.GetAllLanguageAsync();

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DolbyAtmos dolbyAtmos)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var isExist = await _dolbyAtmosService.DolbyAtmosAnyAsync(x => x.FirstTitle.ToLower() == dolbyAtmos.FirstTitle);
            if (isExist)
            {
                ModelState.AddModelError("FirstTitle", "Please change the context.Title is already exist !");
                return View();
            }
            await _dolbyAtmosService.AddDolbyAtmosAsync(dolbyAtmos);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var dolbyAtmos = await _dolbyAtmosService.GetDolbyAtmosWithIdAsync(id.Value);


            ViewBag.Languages = await _languageService.GetAllLanguageAsync();

            if (dolbyAtmos == null)
                return NotFound();

            return View(dolbyAtmos);
        }


        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
                return NotFound();

            var dolbyAtmos = await _dolbyAtmosService.GetDolbyAtmosWithIdAsync(id.Value);


            ViewBag.Languages = await _languageService.GetAllLanguageAsync();



            if (dolbyAtmos == null)
                return NotFound();

            return View(dolbyAtmos);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(DolbyAtmos dolbyAtmos)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var isExist = await _dolbyAtmosService.DolbyAtmosAnyAsync(x => x.FirstTitle.ToLower() == dolbyAtmos.FirstTitle);
            if (isExist)
            {
                ModelState.AddModelError("FirstTitle", "Please change the context.Title is already exist !");
                return View();
            }
            await _dolbyAtmosService.UpdateDolbyAtmosAsync(dolbyAtmos);

            return RedirectToAction("Index");


        }


        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteDolbyAtmos(int? id)
        {
            if (id == null)
                return NotFound();

            var dolbyAtmos = await _dolbyAtmosService.GetDolbyAtmosWithIdAsync(id.Value);
            if (dolbyAtmos == null)
                return NotFound();

            await _dolbyAtmosService.DeleteDolbyAtmosAsync(dolbyAtmos);

            return RedirectToAction("Index");
        }


    }

}
