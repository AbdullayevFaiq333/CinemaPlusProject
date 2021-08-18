using AutoMapper;
using Buisness.Abstract;
using Entity.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaPlus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(IMapper mapper, IContactService contactService)
        {

            _mapper = mapper;
            _contactService = contactService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var contacts = await _contactService.GetAllContactAsync(id);
            var contactDto = _mapper.Map<ContactDto>(contacts);

            return Ok(contactDto);
        }
    }
}
