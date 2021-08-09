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
    public class ContentController : ControllerBase
    {
        private readonly IAboutUsBottomPartService _aboutUsBottomPartService;
        private readonly IMapper _mapper;

        public ContentController(IAboutUsBottomPartService aboutUsBottomPartService, IMapper mapper)
        {
            _aboutUsBottomPartService = aboutUsBottomPartService;
            _mapper = mapper;
        }



        [HttpGet("getContentWebsiteAboutUsBottomPart/{laguageCode}")]

        public async Task<IActionResult> GetContentAboutUsBottomPart([FromRoute] string laguageCode)
        {
            if (string.IsNullOrEmpty(laguageCode))
                return BadRequest();
            var aboutUsBottomPart = await _aboutUsBottomPartService.GetAllAboutUsBottomPartAsync(laguageCode);
            if (aboutUsBottomPart == null)
                return NotFound();

            var aboutUsBottomPartDto = _mapper.Map<AboutUsBottomPartDto>(aboutUsBottomPart);
            return Ok(aboutUsBottomPartDto);
        }

    }
}
