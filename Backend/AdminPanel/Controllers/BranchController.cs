﻿using Buisness.Abstract;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Controllers 
{
    public class BranchController : Controller
    {

        private readonly IBranchService _branchService;
        private readonly ILanguageService _languageService;


        public BranchController(IBranchService branchService, ILanguageService languageService)
        {
            _branchService = branchService;
            _languageService = languageService;

        }
        public async Task<IActionResult> Index()
        {

            var branch = await _branchService.GetAllBranchAsync();

            return View(branch);
        }
        public async Task<IActionResult> Create()
        {

            ViewBag.Languages = await _languageService.GetAllLanguageAsync();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Branch branch)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var isExist = await _branchService.BranchAnyAsync(x => x.Name.ToLower() == branch.Name);
            if (isExist)
            {
                ModelState.AddModelError("Title", "Please change the context.Title is already exist !");
                return View();
            }
            await _branchService.AddBranchAsync(branch);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update()
        {
            ViewBag.Languages = await _languageService.GetAllLanguageAsync();

            return View();
        }
        public async Task<IActionResult> Detail()
        {
            ViewBag.Languages = await _languageService.GetAllLanguageAsync();

            return View();
        }

        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteBranch(int? id)
        {
            if (id == null)
                return NotFound();

            var branch = await _branchService.GetBranchWithIdAsync(id.Value);
            if (branch == null)
                return NotFound();



            await _branchService.DeleteBranchAsync(branch);

            return RedirectToAction("Index");
        }

    }
}
