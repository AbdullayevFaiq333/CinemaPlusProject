using Buisness.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Controllers
{
    public class TicketController : Controller
    {
        private readonly ITicketService _ticketService;

        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        #region Index
        public async Task<IActionResult> Index()
        {

            var ticket = await _ticketService.GetAllTicketAsync();

            return View(ticket);
        }
        #endregion
    }
}
