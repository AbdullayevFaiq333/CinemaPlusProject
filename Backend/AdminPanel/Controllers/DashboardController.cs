using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Controllers
{
    public class DashboardController : Controller
    {
        [Authorize]
        #region Index
        public IActionResult Index()
        {
            return View();
        }
        #endregion
    }
}
