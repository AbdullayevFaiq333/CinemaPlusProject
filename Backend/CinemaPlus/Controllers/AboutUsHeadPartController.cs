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
    public class AboutUsHeadPartController : ControllerBase
    {
        private readonly IRepository<AboutUsHeadPart> _repository;
        private readonly IMapper _mapper;

        public AboutUsHeadPartController(IRepository<AboutUsHeadPart> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var aboutUsHeadParts = await _repository.GetAllAsync();
            var aboutUsHeadPartsDto = _mapper.Map<List<AboutUsHeadPartDto>>(aboutUsHeadParts);

            return Ok(aboutUsHeadPartsDto);
        }
    }
}
