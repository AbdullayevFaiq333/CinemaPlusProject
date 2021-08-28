using Buisness.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Controllers
{
    public class SocialMediaController : Controller
    {
        private readonly ISocialMediaService _socialMediaService;

        public SocialMediaController(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        #region Index
        public async Task<IActionResult> Index()
        {

            var socialMedia = await _socialMediaService.GetAllSocialMediaAsync();

            return View(socialMedia);
        }
        #endregion
    }
}
