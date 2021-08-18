﻿using Buisness.Abstract;
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
    }
}
