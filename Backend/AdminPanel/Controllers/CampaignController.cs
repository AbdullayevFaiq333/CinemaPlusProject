using Buisness.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Controllers
{
    public class CampaignController : Controller
    {
        private readonly ICampaignService _campaignService;
        private readonly ILanguageService _languageService;


        public CampaignController(ICampaignService campaignService, ILanguageService languageService)
        {
            _campaignService = campaignService;
            _languageService = languageService;

        }
        #region Index
        public async Task<IActionResult> Index()
        {

            var campaign = await _campaignService.GetAllCampaignAsync();

            return View(campaign);
        }
        #endregion

        #region Create
        public async Task<IActionResult> Create()
        {

            ViewBag.Languages = await _languageService.GetAllLanguageAsync();

            return View();
        }
        #endregion
    }
}
