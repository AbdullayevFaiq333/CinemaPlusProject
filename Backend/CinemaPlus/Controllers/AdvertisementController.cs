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
    public class AdvertisementController : ControllerBase
    {
        private readonly IRepository<Advertisement> _repository;
        private readonly IMapper _mapper;

        public AdvertisementController(IRepository<Advertisement> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var advertisements = await _repository.GetAllAsync();
            var advertisementDto = _mapper.Map<List<AdvertisementDto>>(advertisements);

            return Ok(advertisementDto);
        }
    }
}
