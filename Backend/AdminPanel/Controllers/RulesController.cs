using Buisness.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Controllers
{
    public class RulesController : Controller
    {
        private readonly IRulesService _rulesService;

        public RulesController(IRulesService rulesService)
        {
            _rulesService = rulesService;
        }

        #region Index
        public async Task<IActionResult> Index()
        {

            var rules = await _rulesService.GetAllRulesAsync();

            return View(rules);
        }
        #endregion
    }
}
