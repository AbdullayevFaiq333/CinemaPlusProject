using Buisness.Abstract;
using Entities.Models;
using Entity.Params;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdminPanel.Controllers 
{
    public class BranchController : Controller
    {

        private readonly IBranchService _branchService;
        private readonly ILanguageService _languageService;
        private readonly IContactService _contactService;
        private readonly ITariffService _tariffService;
        private readonly IPhotosService _photosService;


        public BranchController(IBranchService branchService, ILanguageService languageService, IContactService contactService, ITariffService tariffService, IPhotosService photosService)
        {
            _branchService = branchService;
            _languageService = languageService;
            _contactService = contactService;
            _tariffService = tariffService;
            _photosService = photosService;

        }

        #region Index
        public async Task<IActionResult> Index()
        {

            var branch = await _branchService.GetAllBranchAsync();

            return View(branch);
        }

        #endregion 

        #region Create
        public async Task<IActionResult> Create(int? id)
        {

            ViewBag.Languages = await _languageService.GetAllLanguageAsync();



            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BranchParams brancParams)
        {
            ViewBag.Languages = await _languageService.GetAllLanguageAsync();

            if (!ModelState.IsValid)
            {
                return View();
            }

            var isExist = await _branchService.BranchAnyAsync(x => x.Name.ToLower() == brancParams.Name);
            if (isExist)
            {
                ModelState.AddModelError("Name", "Please change the context.Title is already exist !");
                return View();
            }         


            await _branchService.AddBranchAsync(brancParams);

            return RedirectToAction("Index");
        }
        #endregion

        #region Update
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
                return NotFound();

            ViewBag.Languages = await _languageService.GetAllLanguageAsync();

            var branch = await _branchService.GetBranchWithIdAsync((int)id);


            if (branch == null)
                return NotFound();

            var contact = await _contactService.GetContactWithIdAsync(branch.Id);
            var tariff = await _tariffService.GetTariffWithIdAsync(branch.Id);
            var photos = await _photosService.GetPhotosWithIdAsync(branch.Id);

            if (contact == null)
                return NotFound();
            if (tariff == null)
                return NotFound();
            if (photos == null)
                return NotFound();

            BranchParams branchParams= new()
            {
                MediaSalesDepartment = contact.MediaSalesDepartment,
                WorkingHours = contact.WorkingHours,
                Description = branch.Description,
                OurAddress = contact.OurAddress,
                LanguageId = branch.LanguageId,
                TariffImage = tariff.Image,
                PhotosImage = photos.Image,
                ContactId = contact.Id,
                Phone = contact.Phone,
                Email = contact.Email,
                BranchId = branch.Id,
                TariffId = tariff.Id,
                PhotosId = photos.Id,
                Name = branch.Name,
                Map = contact.Map,
            };
            return View(branchParams);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(BranchParams branchParams, string oldPhoto)
        {
            if (!ModelState.IsValid)
            {
                return View(branchParams);
            }
            ViewBag.Languages = await _languageService.GetAllLanguageAsync();

            var isBranchUpdatedData = await _branchService.UpdateBranchAsync(branchParams, oldPhoto);

            if (isBranchUpdatedData == false)
            {
                // shekilsiz yuklemek olmaz!!!!
            }

            return RedirectToAction("Index");


        }
        #endregion

        #region Detail
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
                return NotFound();

            ViewBag.Languages = await _languageService.GetAllLanguageAsync();

            var branch = await _branchService.GetBranchWithIdAsync((int)id);


            if (branch == null)
                return NotFound();

            var contact = await _contactService.GetContactWithIdAsync(branch.Id);
            var tariff = await _tariffService.GetTariffWithIdAsync(branch.Id);
            var photos = await _photosService.GetPhotosWithIdAsync(branch.Id);

            if (contact == null)
                return NotFound();

            if (tariff == null)
                return NotFound();
             
            if (photos == null)
                return NotFound();

            BranchParams branchParams = new()
            {
                Map = contact.Map,
                Name = branch.Name,
                Email = contact.Email,
                Phone = contact.Phone,
                PhotosImage = photos.Image,
                TariffImage = tariff.Image,
                OurAddress = contact.OurAddress,
                Description = branch.Description,
                WorkingHours = contact.WorkingHours,
                LanguageName = branch.Language.Code,
                MediaSalesDepartment = contact.MediaSalesDepartment,


            };
            return View(branchParams);
        }

        [HttpGet]
        [ActionName("Delete")]

        #endregion

        #region Delete
        public async Task<IActionResult> DeleteBranch(int? id)
        {
            if (id == null)
                return NotFound();

            var movie = await _branchService.GetBranchWithIdAsync(id.Value);
            if (movie == null)
                return NotFound();


            await _branchService.DeleteBranchAsync(id.Value);

            return RedirectToAction("Index");
        }
        #endregion
    } 
}
