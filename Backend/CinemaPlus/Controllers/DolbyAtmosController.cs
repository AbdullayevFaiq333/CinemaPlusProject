using AutoMapper;
using DataAccessLayer;
using DataAccessLayer.Interfaces;
using Entities.Dto;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaPlus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DolbyAtmosController : ControllerBase
    {
        private readonly IRepository<DolbyAtmos> _repository;
        private readonly IMapper _mapper;

        public DolbyAtmosController(IRepository<DolbyAtmos> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var dolbyAtmos = await _repository.GetAllAsync();
            var dolbyAtmosDto = _mapper.Map<List<DolbyAtmosDto>>(dolbyAtmos);

            return Ok(dolbyAtmosDto);
        }

        //[HttpGet("{id}")]
        //public async Task<IActionResult> Get([FromRoute] int? id)
        //{
        //    var dolbyAtmos = await _repository.GetAsync(id.Value);
        //    var dolbyAtmosDto = _mapper.Map<DolbyAtmosDto>(dolbyAtmos);

        //    return Ok(dolbyAtmosDto);
        //}
    }
}
