using Buisness.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Controllers
{
    public class PhotosController : Controller
    {
        private readonly IPhotosService _photosService;

        public PhotosController(IPhotosService photosService)
        {
            _photosService = photosService;
        }
        public async Task<IActionResult> Index()
        {

            var photos = await _photosService.GetAllPhotosAsync();

            return View(photos);
        }
    }
}
