using Buisness.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Controllers
{
    public class RowController : Controller
    {
        private readonly IRowService _rowService;

        public RowController(IRowService rowService)
        {
            _rowService = rowService;
        }
        #region Index
        public async Task<IActionResult> Index()
        {

            var row = await _rowService.GetAllRowAsync();

            return View(row);
        }
        #endregion
    }
}
