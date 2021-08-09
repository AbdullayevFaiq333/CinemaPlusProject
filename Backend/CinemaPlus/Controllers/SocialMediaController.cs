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
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaService _socialMediaService;
        private readonly IMapper _mapper;

        public SocialMediaController(IMapper mapper, ISocialMediaService socialMediaService)
        {

            _mapper = mapper;
            _socialMediaService = socialMediaService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var socialMedias = await _socialMediaService.GetAllSocialMediaAsync();
            var socialMediasDto = _mapper.Map<List<SocialMediaDto>>(socialMedias);

            return Ok(socialMediasDto);
        }
    }
}
