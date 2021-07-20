using DataAccessLayer;
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
        private readonly AppDbContext _dbContext;

        public ServicesController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var services = _dbContext.Services.ToList();
            return View(services);
        }
        public IActionResult Create()
        {
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

            var isExist = await _dbContext.Services.AnyAsync(x => x.Title.ToLower() == service.Title.ToLower());
            if (isExist)
            {
                ModelState.AddModelError("FirstTitle", "Please change the context.Title is already exist !");
                return View();
            }
            await _dbContext.Services.AddAsync(service);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var service = _dbContext.Services.Find(id);

            if (service == null)
                return NotFound();

            return View(service);
        }
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}
