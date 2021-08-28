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

        #region Index
        public async Task<IActionResult> Index()
        {

            var services = await _serviceService.GetAllServiceAsync();

            return View(services);
        }
        #endregion

        #region Create
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

            service.IsDeleted = false;
            await _serviceService.AddServiceAsync(service);

            return RedirectToAction("Index");
        }
        #endregion

        #region Detail
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var service = await _serviceService.GetServiceWithIdAsync(id.Value);


            ViewBag.Languages = await _languageService.GetAllLanguageAsync();

            if (service == null)
                return NotFound();

            return View(service);
        }
        #endregion

        #region Update
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
                return NotFound();

            var service = await _serviceService.GetServiceWithIdAsync(id.Value);

            service.IsDeleted = false;
            ViewBag.Languages = await _languageService.GetAllLanguageAsync();




            if (service == null)
                return NotFound();

            return View(service);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(Service service, string oldPhoto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var isExist = await _serviceService.ServiceAnyAsync(x => x.Title.ToLower() == service.Title);
            if (isExist)
            {
                ModelState.AddModelError("Title", "Please change the context.Title is already exist !");
                return View();
            }
            var isServiceUpdatedData = await _serviceService.UpdateServiceAsync(service, oldPhoto);

            if (isServiceUpdatedData == false)
            {
                // shekilsiz yuklemek olmaz!!!!
            }

            return RedirectToAction("Index");


        }
        #endregion

        #region Delete
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
        #endregion

    }
}
