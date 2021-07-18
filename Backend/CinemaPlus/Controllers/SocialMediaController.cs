﻿using AutoMapper;
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
    public class SocialMediaController : ControllerBase
    {
        private readonly IRepository<SocialMedia> _repository;
        private readonly IMapper _mapper;

        public SocialMediaController(IRepository<SocialMedia> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var socialMedias = await _repository.GetAllAsync();
            var socialMediasDto = _mapper.Map<List<SocialMediaDto>>(socialMedias);

            return Ok(socialMediasDto);
        }
    }
}
