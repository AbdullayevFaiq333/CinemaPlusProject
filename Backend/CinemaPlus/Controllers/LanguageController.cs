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
    public class LanguageController : ControllerBase
    {
        private readonly IRepository<Language> _repository;
        private readonly IMapper _mapper;

        public LanguageController(IRepository<Language> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var languages = await _repository.GetAllAsync();
            var languagesDto = _mapper.Map<List<LanguageDto>>(languages);

            return Ok(languagesDto);
        }
    }
}