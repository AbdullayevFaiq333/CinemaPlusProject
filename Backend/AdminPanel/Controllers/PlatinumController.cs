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
        public IActionResult Update(int? id)
        {
            if (id == null)
                return NotFound();

            var platinum = _dbContext.Platiniums.Find(id);

            if (platinum == null)
                return NotFound();

            return View(platinum);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(int? id, Platinium platinum)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (id == null)
                return NotFound();

            if (id != platinum.Id)
                return BadRequest();

            var dBplatinum = await _dbContext.Platiniums.FindAsync(id);
            if (dBplatinum == null)
                return NotFound();

            var isExist = await _dbContext.Platiniums.AnyAsync(x => x.Title.ToLower() == platinum.Title.
                                                                                 ToLower() && x.Id != id);
            if (isExist)
            {
                ModelState.AddModelError("Title", "Please change the context.Title is already exist !");
                return View();
            }

            dBplatinum.Title = platinum.Title;
            dBplatinum.Description = platinum.Description;

            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Index");


        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var platinum = await _dbContext.Platiniums.FindAsync(id);

            if (platinum == null)
                return NotFound();

            return View(platinum);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePlatinum(int? id)
        {
            if (id == null)
                return NotFound();

            var platinum = await _dbContext.Platiniums.FindAsync(id);

            if (platinum == null)
                return NotFound();

            _dbContext.Platiniums.Remove(platinum);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }

    }
}
