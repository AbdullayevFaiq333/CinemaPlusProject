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
    public class TicketController : ControllerBase
    {
        private readonly ITicketService _ticketService;
        private readonly IMapper _mapper;

        public TicketController(IMapper mapper, ITicketService ticketService)
        {

            _mapper = mapper;
            _ticketService = ticketService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {

            var tickets = await _ticketService.GetAllTicketAsync(id);
            var ticketDto = _mapper.Map<List<TicketDto>>(tickets);

            return Ok(ticketDto);
        }
    }
}
