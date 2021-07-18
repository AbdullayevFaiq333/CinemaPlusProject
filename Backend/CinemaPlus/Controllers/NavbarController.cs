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
    public class NavbarController : ControllerBase
    {
        private readonly IRepository<Navbar> _repository;
        private readonly IMapper _mapper;

        public NavbarController(IRepository<Navbar> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var navbars = await _repository.GetAllAsync();
            var navbarDto = _mapper.Map<List<NavbarDto>>(navbars);

            return Ok(navbarDto);
        }
    }
}
