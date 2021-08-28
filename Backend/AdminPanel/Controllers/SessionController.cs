using Buisness.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Controllers
{
    public class SessionController : Controller
    {
        private readonly ISessionService _sessionService;
        private readonly ILanguageService _languageService;

        public SessionController(ISessionService sessionService, ILanguageService languageService)
        {
            _sessionService = sessionService;
            _languageService = languageService;
        }
        public async Task<IActionResult> Index()
        {
            
            var session = await _sessionService.GetAllSessionAsync();


            return View(session);
        }
      

    }
}
