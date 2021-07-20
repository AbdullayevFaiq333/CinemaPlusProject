using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Controllers
{
    public class PlatinumController : Controller
    {
        private readonly AppDbContext _dbContext;

        public PlatinumController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var platinum = _dbContext.Platiniums.ToList();
            return View(platinum);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Platinium platinum)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var isExist = await _dbContext.Platiniums.AnyAsync(x => x.Title.ToLower() == platinum.Title.ToLower());
            if (isExist)
            {
                ModelState.AddModelError("FirstTitle", "Please change the context.Title is already exist !");
                return View();
            }
            await _dbContext.Platiniums.AddAsync(platinum);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var platinum = _dbContext.Platiniums.Find(id);

            if (platinum == null)
                return NotFound();

            return View(platinum);
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
