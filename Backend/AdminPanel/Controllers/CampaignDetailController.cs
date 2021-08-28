using Buisness.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Controllers
{
    public class CampaignDetailController : Controller
    {
        private readonly ICampaignDetailService _campaignDetailService;

        public CampaignDetailController(ICampaignDetailService campaignDetailService)
        {
            _campaignDetailService = campaignDetailService;
        }
        #region Index
        public async Task<IActionResult> Index()
        {

            var campaignDetail = await _campaignDetailService.GetAllCampaignDetailAsync();

            return View(campaignDetail);
        }
        #endregion
    }
}
