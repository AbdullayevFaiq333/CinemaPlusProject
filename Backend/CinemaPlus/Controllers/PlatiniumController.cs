using AutoMapper;
using DataAccessLayer.Interfaces;
using Entities.Dto;
using Entities.Models;
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
    public class PlatiniumController : ControllerBase
    {
        private readonly IRepository<Platinium> _repository;
        private readonly IMapper _mapper;

        public PlatiniumController(IRepository<Platinium> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var platiniums = await _repository.GetAllAsync();
            var platiniumsDto = _mapper.Map<List<PlatiniumDto>>(platiniums);

            return Ok(platiniumsDto);
        }
    }
}
