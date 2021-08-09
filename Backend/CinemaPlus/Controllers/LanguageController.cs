using AutoMapper;
using Buisness.Abstract;
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
        private readonly ILanguageService _languageService;
        private readonly IMapper _mapper;

        public LanguageController(IMapper mapper, ILanguageService languageService)
        {

            _mapper = mapper;
            _languageService = languageService;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var languages = await _languageService.GetAllLanguageAsync();
            var languagesDto = _mapper.Map<List<LanguageDto>>(languages);

            return Ok(languagesDto);
        }
    }
}
