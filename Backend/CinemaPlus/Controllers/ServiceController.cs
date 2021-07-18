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
    public class ServiceController : ControllerBase
    {
        private readonly IRepository<Service> _repository;
        private readonly IMapper _mapper;

        public ServiceController(IRepository<Service> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var services = await _repository.GetAllAsync();
            var servicesDto = _mapper.Map<List<ServiceDto>>(services);

            return Ok(servicesDto);
        }
    }
}
