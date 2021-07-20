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
    public class AboutUsBottomPartController : ControllerBase
    {
        private readonly IRepository<AboutUsBottomPart> _repository;
        private readonly IMapper _mapper;

        public AboutUsBottomPartController(IRepository<AboutUsBottomPart> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var aboutUsBottomParta = await _repository.GetAllAsync();
            var aboutUsBottomPartaDto = _mapper.Map<List<AboutUsBottomPartDto>>(aboutUsBottomParta);

            return Ok(aboutUsBottomPartaDto);
        }
    }
}
