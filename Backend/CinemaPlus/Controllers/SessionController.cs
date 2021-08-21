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
    public class SessionController : ControllerBase
    {
        private readonly ISessionService _sessionService;
        private readonly IMapper _mapper;

        public SessionController(IMapper mapper, ISessionService sessionService)
        {

            _mapper = mapper;
            _sessionService = sessionService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var sessions = await _sessionService.GetAllSessionAsync();
            var sessionDto = _mapper.Map<List<SessionDto>>(sessions);

            return Ok(sessionDto);
        }
    }
}
