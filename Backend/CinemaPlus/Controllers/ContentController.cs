using AutoMapper;
using Buisness.Abstract;
using Entities.Dto;
using Entities.Models;
using Entity.Dto;
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
        private readonly IAboutUsHeadPartService _aboutUsHeadPartService;
        private readonly IBranchService _branchService;
        private readonly ICampaignService _campaignService;
        private readonly ICampaignDetailService _campaignDetailService;
        private readonly ICinemaClubService _cinemaClubService;
        private readonly IDolbyAtmosService _dolbyAtmosService;
        private readonly IFAQService _fAQService;
        private readonly IFooterService _footerService;
        private readonly ISecondFooterService _secondFooterService;
        private readonly INavbarService _navbarService;
        private readonly ISecondNavbarService _secondNavbarService;
        private readonly INewsService _newsService;
        private readonly IPlatiniumService _platiniumService;
        private readonly IServiceService _serviceService;
        private readonly IRulesService _rulesService;
       
        private readonly IMapper _mapper;

        public ContentController(IAboutUsBottomPartService aboutUsBottomPartService, IMapper mapper,
            IAboutUsHeadPartService aboutUsHeadPartService, IBranchService branchService, ICampaignService campaignService,
            ICampaignDetailService campaignDetailService, ICinemaClubService cinemaClubService, IDolbyAtmosService dolbyAtmosService,
            IFAQService fAQService, IFooterService footerService, ISecondFooterService secondFooterService, INavbarService navbarService,
            ISecondNavbarService secondNavbarService, INewsService newsService, IPlatiniumService platiniumService,
            IServiceService serviceService, IRulesService rulesService)
        {
            _aboutUsBottomPartService = aboutUsBottomPartService;
            _mapper = mapper;
            _aboutUsHeadPartService = aboutUsHeadPartService;
            _branchService = branchService;
            _campaignService = campaignService;
            _campaignDetailService = campaignDetailService;
            _cinemaClubService = cinemaClubService;
            _dolbyAtmosService = dolbyAtmosService;
            _fAQService = fAQService;
            _footerService = footerService;
            _secondFooterService = secondFooterService;
            _navbarService = navbarService;
            _secondNavbarService = secondNavbarService;
            _newsService = newsService;
            _platiniumService = platiniumService;
            _serviceService = serviceService;
            _rulesService = rulesService;
        }



        [HttpGet("getContentWebsiteAboutUsBottomPart/{laguageCode}")]

        public async Task<IActionResult> GetContentAboutUsBottomPart([FromRoute] string laguageCode)
        {
            if (string.IsNullOrEmpty(laguageCode))
                return BadRequest();
            var aboutUsBottomPart = await _aboutUsBottomPartService.GetAllAboutUsBottomPartAsync(laguageCode);
            if (aboutUsBottomPart == null)
                return NotFound();

            var aboutUsBottomPartDto = _mapper.Map<List<AboutUsBottomPartDto>>(aboutUsBottomPart);
            return Ok(aboutUsBottomPartDto);
        }

        [HttpGet("getContentWebsiteAboutUsHeadPart/{laguageCode}")]

        public async Task<IActionResult> GetContentAboutUsHeadPart([FromRoute] string laguageCode)
        {
            if (string.IsNullOrEmpty(laguageCode))
                return BadRequest();
            var aboutUsHeadPart = await _aboutUsHeadPartService.GetAllAboutUsHeadPartAsync(laguageCode);
            if (aboutUsHeadPart == null)
                return NotFound();

            var aboutUsHeadPartDto = _mapper.Map< List<AboutUsHeadPartDto>>(aboutUsHeadPart);
            return Ok(aboutUsHeadPartDto);
        }

        [HttpGet("getContentWebsiteBranch/{laguageCode}")]

        public async Task<IActionResult> GetContentBranch([FromRoute] string laguageCode)
        {
            if (string.IsNullOrEmpty(laguageCode))
                return BadRequest();
            var branches = await _branchService.GetAllBranchAsync(laguageCode);
            if (branches == null)
                return NotFound();

            var branchDto = _mapper.Map< List<BranchDto>>(branches);
            return Ok(branchDto);
        }

        [HttpGet("getContentWebsiteCampaign/{laguageCode}")]

        public async Task<IActionResult> GetContentCampaign([FromRoute] string laguageCode)
        {
            if (string.IsNullOrEmpty(laguageCode))
                return BadRequest();
            var campaigns = await _campaignService.GetAllCampaignAsync(laguageCode);
            if (campaigns == null)
                return NotFound();

            var campaignDto = _mapper.Map<List<CampaignDto>>(campaigns);
            return Ok(campaignDto);
        }

        [HttpGet("getContentWebsiteCampaignDetail/{laguageCode}")]

        public async Task<IActionResult> GetContentCampaignDetail([FromRoute] string laguageCode,int id)
        {
            if (string.IsNullOrEmpty(laguageCode))
                return BadRequest();
            var campaignDetails = await _campaignDetailService.GetAllCampaignDetailAsync(laguageCode,id);
            if (campaignDetails == null)
                return NotFound();

            var campaignDetailDto = _mapper.Map<CampaignDetailDto>(campaignDetails);
            return Ok(campaignDetailDto);
        }


        [HttpGet("getContentWebsiteCinemaClub/{laguageCode}")]

        public async Task<IActionResult> GetContentCinemaClub([FromRoute] string laguageCode)
        {
            if (string.IsNullOrEmpty(laguageCode))
                return BadRequest();
            var cinemaClubs = await _cinemaClubService.GetAllCinemaClubAsync(laguageCode);
            if (cinemaClubs == null)
                return NotFound();

            var cinemaClubDto = _mapper.Map<List<CinemaClubDto>>(cinemaClubs);
            return Ok(cinemaClubDto);
        }


        [HttpGet("getContentWebsiteDolbyAtmos/{laguageCode}")]

        public async Task<IActionResult> GetContentDolbyAtmos([FromRoute] string laguageCode)
        {
            if (string.IsNullOrEmpty(laguageCode))
                return BadRequest();
            var dolbyAtmos = await _dolbyAtmosService.GetAllDolbyAtmosAsync(laguageCode);
            if (dolbyAtmos == null)
                return NotFound();

            var dolbyAtmosDto = _mapper.Map<List<DolbyAtmosDto>>(dolbyAtmos);
            return Ok(dolbyAtmosDto);
        }


        [HttpGet("getContentWebsiteFAQ/{laguageCode}")]

        public async Task<IActionResult> GetContentFAQ([FromRoute] string laguageCode)
        {
            if (string.IsNullOrEmpty(laguageCode))
                return BadRequest();
            var fAQs = await _fAQService.GetAllFAQAsync(laguageCode);
            if (fAQs == null)
                return NotFound();

            var fAQDto = _mapper.Map<List<FAQDto>>(fAQs);
            return Ok(fAQDto);
        }


        [HttpGet("getContentWebsiteFooter/{laguageCode}")]

        public async Task<IActionResult> GetContentFooter([FromRoute] string laguageCode)
        {
            if (string.IsNullOrEmpty(laguageCode))
                return BadRequest();
            var footers = await _footerService.GetAllFooterAsync(laguageCode);
            if (footers == null)
                return NotFound();

            var footerDto = _mapper.Map<List<FooterDto>>(footers);
            return Ok(footerDto);
        }

        [HttpGet("getContentWebsiteSecondFooter/{laguageCode}")]

        public async Task<IActionResult> GetContentSecondFooter([FromRoute] string laguageCode)
        {
            if (string.IsNullOrEmpty(laguageCode))
                return BadRequest();
            var secondFooters = await _secondFooterService.GetAllSecondFooterAsync(laguageCode);
            if (secondFooters == null)
                return NotFound();

            var secondFooterDto = _mapper.Map<List<SecondFooterDto>>(secondFooters);
            return Ok(secondFooterDto);
        }


        [HttpGet("getContentWebsiteNavbar/{laguageCode}")]

        public async Task<IActionResult> GetContentNavbar([FromRoute] string laguageCode)
        {
            if (string.IsNullOrEmpty(laguageCode))
                return BadRequest();
            var navbars = await _navbarService.GetAllNavbarAsync(laguageCode);
            var secondNavbars = await _secondNavbarService.GetAllSecondNavbarAsync(laguageCode);
            if (navbars == null&& secondNavbars==null)
                return NotFound();

            var contentNavbarDto = new ContentNavbarDto
            {
                NavbarDto = _mapper.Map<List<NavbarDto>>(navbars),
                SecondNavbarDto = _mapper.Map<List<SecondNavbarDto>>(secondNavbars),
            };
            
            return Ok(contentNavbarDto);
        }


        [HttpGet("getContentWebsiteNews/{laguageCode}")]

        public async Task<IActionResult> GetContentNews([FromRoute] string laguageCode)
        {
            if (string.IsNullOrEmpty(laguageCode))
                return BadRequest();
            var news = await _newsService.GetAllNewsAsync(laguageCode);
            if (news == null)
                return NotFound();

            var newsDto = _mapper.Map<List<NewsDto>>(news);
            return Ok(newsDto);
        }


        [HttpGet("getContentWebsitePlatinium/{laguageCode}")]

        public async Task<IActionResult> GetContentPlatinium([FromRoute] string laguageCode)
        {
            if (string.IsNullOrEmpty(laguageCode))
                return BadRequest();
            var platiniums = await _platiniumService.GetAllPlatiniumAsync(laguageCode);
            if (platiniums == null)
                return NotFound();

            var platiniumDto = _mapper.Map<List<PlatiniumDto>>(platiniums);
            return Ok(platiniumDto);
        }


        [HttpGet("getContentWebsiteService/{laguageCode}")]

        public async Task<IActionResult> GetContentService([FromRoute] string laguageCode)
        {
            if (string.IsNullOrEmpty(laguageCode))
                return BadRequest();
            var services = await _serviceService.GetAllServiceAsync(laguageCode);
            if (services == null)
                return NotFound();

            var serviceDto = _mapper.Map<List<ServiceDto>>(services);
            return Ok(serviceDto);
        }


        [HttpGet("getContentWebsiteRules/{laguageCode}")]

        public async Task<IActionResult> GetContentRules([FromRoute] string laguageCode)
        {
            if (string.IsNullOrEmpty(laguageCode))
                return BadRequest();
            var rules = await _rulesService.GetAllRulesAsync(laguageCode);
            if (rules == null)
                return NotFound();

            var rulesDto = _mapper.Map<List<RulesDto>>(rules);
            return Ok(rulesDto);
        }

    }
}
