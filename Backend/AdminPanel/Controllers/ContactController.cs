using Buisness.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        #region Index
        public async Task<IActionResult> Index()
        {

            var contact = await _contactService.GetAllContactAsync();

            return View(contact);
        }
        #endregion
    }
}
