using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Controllers
{
    public class DolbyAtmosController : Controller
    {
        private readonly AppDbContext _dbContext;

        public DolbyAtmosController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var dolbyAtmos = _dbContext.DolbyAtmos.ToList();
            return View(dolbyAtmos);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Detail()
        {
            return View();
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
