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
    public class SeatController : ControllerBase
    {
        private readonly ISeatService _seatService;
        private readonly IMapper _mapper;

        public SeatController(IMapper mapper, ISeatService seatService)
        {

            _mapper = mapper;
            _seatService = seatService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var seats = await _seatService.GetAllSeatAsync(id);
            var seatDto = _mapper.Map<List<SeatDto>>(seats);

            return Ok(seatDto);
        }
    }
}
