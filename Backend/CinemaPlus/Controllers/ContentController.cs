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
    public class ContentController : ControllerBase
    {
        private readonly IRepository<DolbyAtmos> _repositoryDolbyAtmos;
        private readonly IRepository<Platinium> _repositoryPlatinium;
        private readonly IRepository<Service> _repositoryService;
        private readonly IRepository<CinemaClub> _repositoryCinemaClub;
        private readonly IRepository<Navbar> _repositoryNavbar;
        private readonly IRepository<Footer> _repositoryFooter;
        private readonly IRepository<SocialMedia> _repositorySocialMedia;
        private readonly IRepository<News> _repositoryNews;
        private readonly IMapper _mapper;

        public ContentController(IRepository<DolbyAtmos> repositoryDolbyAtmos, IMapper mapper, IRepository<Platinium> repositoryPlatinium = null, IRepository<Service> repositoryService = null, IRepository<CinemaClub> repositoryCinemaClub = null, IRepository<Navbar> repositoryNavbar = null, IRepository<Footer> repositoryFooter = null, IRepository<SocialMedia> repositorySocialMedia = null, IRepository<News> repositoryNews = null)
        {
            _repositoryDolbyAtmos = repositoryDolbyAtmos;
            _mapper = mapper;
            _repositoryPlatinium = repositoryPlatinium;
            _repositoryService = repositoryService;
            _repositoryCinemaClub = repositoryCinemaClub;
            _repositoryNavbar = repositoryNavbar;
            _repositoryFooter = repositoryFooter;
            _repositorySocialMedia = repositorySocialMedia;
            _repositoryNews = repositoryNews;
        }

        [HttpGet("getContentWebsite/{laguageCode}")]

        public async Task<IActionResult> GetContent([FromRoute] string laguageCode)
        {
            if (string.IsNullOrEmpty(laguageCode))
                return BadRequest();
            var includeProperties = new List<string>
            {
                nameof(Language)
                
            };
            var dolbyAtmos = await _repositoryDolbyAtmos.GetAllAsync(x => x.Language.Code.ToLower()==laguageCode.ToLower(),includeProperties);
            var platiniums = await _repositoryPlatinium.GetAllAsync(x => x.Language.Code.ToLower() == laguageCode.ToLower(), includeProperties);
            var services = await _repositoryService.GetAllAsync(x => x.Language.Code.ToLower() == laguageCode.ToLower(), includeProperties);
            var cinemaClubs = await _repositoryCinemaClub.GetAllAsync(x => x.Language.Code.ToLower() == laguageCode.ToLower(), includeProperties);
            var navbars = await _repositoryNavbar.GetAllAsync(x => x.Language.Code.ToLower() == laguageCode.ToLower(), includeProperties);
            var footers = await _repositoryFooter.GetAllAsync(x => x.Language.Code.ToLower() == laguageCode.ToLower(), includeProperties);
            var socialMedias = await _repositorySocialMedia.GetAllAsync(x => x.Language.Code.ToLower() == laguageCode.ToLower(), includeProperties);
            var news = await _repositoryNews.GetAllAsync(x => x.Language.Code.ToLower() == laguageCode.ToLower(), includeProperties);

            var contentDto = new ContentDto
            {
                DolbyAtmosDto = _mapper.Map<List<DolbyAtmosDto>>(dolbyAtmos),
                PlatiniumDto = _mapper.Map<List<PlatiniumDto>>(platiniums),
                ServiceDto=_mapper.Map<List<ServiceDto>>(services),
                CinemaClubDto = _mapper.Map<List<CinemaClubDto>>(cinemaClubs),
                NavbarDto = _mapper.Map<List<NavbarDto>>(navbars),
                FooterDto = _mapper.Map<List<FooterDto>>(footers),
                SocialMediaDto = _mapper.Map<List<SocialMediaDto>>(socialMedias),
                NewsDto = _mapper.Map<List<NewsDto>>(news)
            };

            return Ok(contentDto);
        }
    }
}
