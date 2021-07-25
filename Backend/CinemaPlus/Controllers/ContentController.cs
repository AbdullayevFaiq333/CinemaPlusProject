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
        private readonly IRepository<AboutUsHeadPart> _repositoryAboutUsHeadPart;
        private readonly IRepository<AboutUsBottomPart> _repositoryAboutUsBottomPart;
        private readonly IRepository<Rules> _repositoryRules;
        private readonly IRepository<FAQ> _repositoryFAQ;
        private readonly IRepository<SecondNavbar> _repositorySecondNavbar;
        private readonly IMapper _mapper;

        public ContentController(IRepository<DolbyAtmos> repositoryDolbyAtmos, IMapper mapper, IRepository<Platinium> repositoryPlatinium = null, IRepository<Service> repositoryService = null, IRepository<CinemaClub> repositoryCinemaClub = null, IRepository<Navbar> repositoryNavbar = null, IRepository<Footer> repositoryFooter = null, IRepository<SocialMedia> repositorySocialMedia = null, IRepository<News> repositoryNews = null, IRepository<AboutUsHeadPart> repositoryAboutUsHeadPart = null, IRepository<AboutUsBottomPart> repositoryAboutUsBottomPart = null, IRepository<Rules> repositoryRules = null, IRepository<FAQ> repositoryFAQ = null, IRepository<SecondNavbar> repositorySecondNavbar = null)
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
            _repositoryAboutUsHeadPart = repositoryAboutUsHeadPart;
            _repositoryAboutUsBottomPart = repositoryAboutUsBottomPart;
            _repositoryRules = repositoryRules;
            _repositoryFAQ = repositoryFAQ;
            _repositorySecondNavbar = repositorySecondNavbar;
        }

        [HttpGet("getContentWebsiteDolbyAtmos/{laguageCode}")]

        public async Task<IActionResult> GetContentDolbyAtmos([FromRoute] string laguageCode)
        {
            if (string.IsNullOrEmpty(laguageCode))
                return BadRequest();
            var includeProperties = new List<string>
            {
                nameof(Language)
            };
            var dolbyAtmos = await _repositoryDolbyAtmos.GetAllAsync(x => x.Language.Code.ToLower()==laguageCode.ToLower(),includeProperties);
            var dolbyAtmosDto = _mapper.Map<List<DolbyAtmosDto>>(dolbyAtmos);
                
            return Ok(dolbyAtmosDto);
        }


        
        
        [HttpGet("getContentWebsitePlatinum/{laguageCode}")]

        public async Task<IActionResult> GetContentPlatinum([FromRoute] string laguageCode)
        {
            if (string.IsNullOrEmpty(laguageCode))
                return BadRequest();
            var includeProperties = new List<string>
            {
                nameof(Language)

            };
            
            var platiniums = await _repositoryPlatinium.GetAllAsync(x => x.Language.Code.ToLower() == laguageCode.ToLower(), includeProperties);
            var platiniumDto = _mapper.Map<List<PlatiniumDto>>(platiniums);

            return Ok(platiniumDto);
        }


        [HttpGet("getContentWebsiteService/{laguageCode}")]

        public async Task<IActionResult> GetContentService([FromRoute] string laguageCode)
        {
            if (string.IsNullOrEmpty(laguageCode))
                return BadRequest();
            var includeProperties = new List<string>
            {
                nameof(Language)

            };

            var services = await _repositoryService.GetAllAsync(x => x.Language.Code.ToLower() == laguageCode.ToLower(), includeProperties);
            var serviceDto = _mapper.Map<List<ServiceDto>>(services);

            return Ok(serviceDto);
        }


        [HttpGet("getContentWebsiteCinemaClub/{laguageCode}")]

        public async Task<IActionResult> GetContentCinemaClub([FromRoute] string laguageCode)
        {
            if (string.IsNullOrEmpty(laguageCode))
                return BadRequest();
            var includeProperties = new List<string>
            {
                nameof(Language)

            };

            var cinemaClubs = await _repositoryCinemaClub.GetAllAsync(x => x.Language.Code.ToLower() == laguageCode.ToLower(), includeProperties);
            var cinemaClubDto = _mapper.Map<List<CinemaClubDto>>(cinemaClubs);


            return Ok(cinemaClubDto);
        }


        [HttpGet("getContentWebsiteNavbar/{laguageCode}")]

        public async Task<IActionResult> GetContentNavbar([FromRoute] string laguageCode)
        {
            if (string.IsNullOrEmpty(laguageCode))
                return BadRequest();
            var includeProperties = new List<string>
            {
                nameof(Language)

            };

            var navbars = await _repositoryNavbar.GetAllAsync(x => x.Language.Code.ToLower() == laguageCode.ToLower(), includeProperties);
            var secondNavbars = await _repositorySecondNavbar.GetAllAsync(x => x.Language.Code.ToLower() == laguageCode.ToLower(), includeProperties);

            var contentNavbarDto = new ContentNavbarDto
            {

                NavbarDto = _mapper.Map<List<NavbarDto>>(navbars),
                SecondNavbarDto = _mapper.Map<List<SecondNavbarDto>>(secondNavbars),
            };
            


            return Ok(contentNavbarDto);
        }


        [HttpGet("getContentWebsiteFooter/{laguageCode}")]

        public async Task<IActionResult> GetContentFooter([FromRoute] string laguageCode)
        {
            if (string.IsNullOrEmpty(laguageCode))
                return BadRequest();
            var includeProperties = new List<string>
            {
                nameof(Language)

            };

            var footers = await _repositoryFooter.GetAllAsync(x => x.Language.Code.ToLower() == laguageCode.ToLower(), includeProperties);
            var footerDto = _mapper.Map<List<FooterDto>>(footers);


            return Ok(footerDto);
        }


        [HttpGet("getContentWebsiteSocialMedia/{laguageCode}")]

        public async Task<IActionResult> GetContentSocialMedia([FromRoute] string laguageCode)
        {
            if (string.IsNullOrEmpty(laguageCode))
                return BadRequest();
            var includeProperties = new List<string>
            {
                nameof(Language)

            };

            var socialMedias = await _repositorySocialMedia.GetAllAsync(x => x.Language.Code.ToLower() == laguageCode.ToLower(), includeProperties);
            var socialMediaDto = _mapper.Map<List<SocialMediaDto>>(socialMedias);


            return Ok(socialMediaDto);
        }


        [HttpGet("getContentWebsiteNews/{laguageCode}")]

        public async Task<IActionResult> GetContentNews([FromRoute] string laguageCode)
        {
            if (string.IsNullOrEmpty(laguageCode))
                return BadRequest();
            var includeProperties = new List<string>
            {
                nameof(Language)

            };

            var news = await _repositoryNews.GetAllAsync(x => x.Language.Code.ToLower() == laguageCode.ToLower(), includeProperties);
            var newsDto = _mapper.Map<List<NewsDto>>(news);


            return Ok(newsDto);
        }


        [HttpGet("getContentWebsiteAboutUs/{laguageCode}")]

        public async Task<IActionResult> GetContentAboutUs([FromRoute] string laguageCode)
        {
            if (string.IsNullOrEmpty(laguageCode))
                return BadRequest();
            var includeProperties = new List<string>
            {
                nameof(Language)

            };

            var aboutUsHeadParts = await _repositoryAboutUsHeadPart.GetAllAsync(x => x.Language.Code.ToLower() == laguageCode.ToLower(), includeProperties);
            var aboutUsBottomParts = await _repositoryAboutUsBottomPart.GetAllAsync(x => x.Language.Code.ToLower() == laguageCode.ToLower(), includeProperties);

            var contentAboutUsDto = new ContentAboutUsDto
            {
                
                AboutUsHeadPartDto = _mapper.Map<List<AboutUsHeadPartDto>>(aboutUsHeadParts),
                AboutUsBottomPartDto = _mapper.Map<List<AboutUsBottomPartDto>>(aboutUsBottomParts)
            };


            return Ok(contentAboutUsDto);
        }



        [HttpGet("getContentWebsiteRules/{laguageCode}")]

        public async Task<IActionResult> GetContentRules([FromRoute] string laguageCode)
        {
            if (string.IsNullOrEmpty(laguageCode))
                return BadRequest();
            var includeProperties = new List<string>
            {
                nameof(Language)

            };

            var rules = await _repositoryRules.GetAllAsync(x => x.Language.Code.ToLower() == laguageCode.ToLower(), includeProperties);
            var rulesDto = _mapper.Map<List<RulesDto>>(rules);


            return Ok(rulesDto);
        }


        [HttpGet("getContentWebsiteFAQ/{laguageCode}")]

        public async Task<IActionResult> GetContentFAQ([FromRoute] string laguageCode)
        {
            if (string.IsNullOrEmpty(laguageCode))
                return BadRequest();
            var includeProperties = new List<string>
            {
                nameof(Language)

            };

            var fAQs = await _repositoryFAQ.GetAllAsync(x => x.Language.Code.ToLower() == laguageCode.ToLower(), includeProperties);
            var fAQDto = _mapper.Map<List<FAQDto>>(fAQs);


            return Ok(fAQDto);
        }

    }
}
