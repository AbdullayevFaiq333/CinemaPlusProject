using AutoMapper;
using Buisness.Abstract;
using Entities.Dto;
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
        private readonly IAdvertisementService _advertisementService;
        private readonly IMapper _mapper;

        public AdvertisementController(IMapper mapper, IAdvertisementService advertisementService)
        {

            _mapper = mapper;
            _advertisementService = advertisementService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var advertisements = await _advertisementService.GetAllAdvertisementAsync();
            var advertisementDto = _mapper.Map<List<AdvertisementDto>>(advertisements);

            return Ok(advertisementDto);
        }
    }
}
