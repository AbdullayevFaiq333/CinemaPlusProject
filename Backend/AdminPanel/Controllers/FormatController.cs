using Buisness.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Controllers
{
    public class FormatController : Controller
    {
        private readonly IFormatService _formatService;

        public FormatController(IFormatService formatService)
        {
            _formatService = formatService;
        }
        #region Index
        public async Task<IActionResult> Index()
        {

            var format = await _formatService.GetAllFormatAsync();

            return View(format);
        }
        #endregion
    }
}
