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
    public class CinemaClubController : ControllerBase
    {
        private readonly IRepository<CinemaClub> _repository;
        private readonly IMapper _mapper;

        public CinemaClubController(IRepository<CinemaClub> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var cinemaClubs = await _repository.GetAllAsync();
            var cinemaClubsDto = _mapper.Map<List<CinemaClubDto>>(cinemaClubs);

            return Ok(cinemaClubsDto);
        }
    }
}
