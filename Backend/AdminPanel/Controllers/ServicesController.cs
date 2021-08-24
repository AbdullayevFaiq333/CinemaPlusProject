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
    public class ServicesController : Controller 
    {
        private readonly IServiceService _serviceService;
        private readonly ILanguageService _languageService;


        public ServicesController(IServiceService serviceService, ILanguageService languageService)
        {
            _serviceService = serviceService;
            _languageService = languageService;

        }
        public async Task<IActionResult> Index()
        {

            var services = await _serviceService.GetAllServiceAsync();

            return View(services);
        }
        public async Task <IActionResult> Create()
        {
            ViewBag.Languages = await _languageService.GetAllLanguageAsync();


            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Service service)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var isExist = await _serviceService.ServiceAnyAsync(x => x.Title.ToLower() == service.Title);
            if (isExist)
            {
                ModelState.AddModelError("Name", "Please change the context.Title is already exist !");
                return View();
            }
            await _serviceService.AddServiceAsync(service);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var service = await _serviceService.GetAllServiceAsync();




            ViewBag.Languages = await _languageService.GetAllLanguageAsync();

            if (service == null)
                return NotFound();

            return View(service);
        }
        //public IActionResult Update(int? id)
        //{
        //    if (id == null)
        //        return NotFound();

        //    var service = _dbContext.Services.Find(id);
        //    ViewBag.Languages = _dbContext.Languages.ToList();


        //    if (service == null)
        //        return NotFound();

        //    return View(service);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]

        //public async Task<IActionResult> Update(int? id, Service service)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View();
        //    }

        //    if (id == null)
        //        return NotFound();

        //    if (id != service.Id )
        //        return BadRequest();

        //    var dBservice = await _dbContext.Services.FindAsync(id);
        //    if (dBservice == null)
        //        return NotFound();

        //    var isExist = await _dbContext.Services.AnyAsync(x => x.Title.ToLower() == service.Title.
        //                                                                         ToLower() && x.Id != id);
        //    if (isExist)
        //    {
        //        ModelState.AddModelError("Title", "Please change the context.Title is already exist !");
        //        return View();
        //    }

        //    dBservice.Title = service.Title;
        //    dBservice.Description = service.Description;

        //    await _dbContext.SaveChangesAsync();
        //    return RedirectToAction("Index");


        //}


        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteService(int? id)
        {
            if (id == null)
                return NotFound();

            var movie = await _serviceService.GetServiceWithIdAsync(id.Value);
            if (movie == null)
                return NotFound();


            await _serviceService.DeleteServiceAsync(movie);

            return RedirectToAction("Index");
        }

    }
}
