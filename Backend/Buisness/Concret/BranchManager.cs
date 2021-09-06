using Buisness.Abstract;
using DataAccess.Abstract;
using Entities.Models;
using Entity.Params;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concret
{
    public class BranchManager : IBranchService
    {
        private readonly IBranchDal _branchDal;
        private readonly IHostEnvironment _environment;
        private readonly IContactDal _contactDal;
        private readonly ITariffDal _tariffDal;
        private readonly IPhotosDal _photosDal;
         

        public BranchManager(IBranchDal branchDal, IHostEnvironment environment, IContactDal contactDal, ITariffDal tariffDal, IPhotosDal photosDal)
        {
            _branchDal = branchDal;
            _environment = environment;
            _contactDal = contactDal;
            _tariffDal = tariffDal;
            _photosDal = photosDal;
        }

        public async Task<Branch> GetBranchWithIdAsync(int id) 
        {
            return await _branchDal.GetBranchWithInclude(id);
            //return await _branchDal.GetAsync(x => x.Id == id);
        }

        public async Task<List<Branch>> GetAllBranchAsync()
        {
            return await _branchDal.GetAllAsync();
        }

        public async Task<bool> AddBranchAsync(BranchParams branchParams)
        {
            if (branchParams == null)
                return false;


            var newFileNamePhoto = string.Empty;
            if (branchParams.PhotosPhoto != null)
            {
                if (branchParams.PhotosPhoto.Length > 0 &&
                    (branchParams.PhotosPhoto.ContentType == "image/jpeg"
                      || branchParams.PhotosPhoto.ContentType == "image/jpg"
                    || branchParams.PhotosPhoto.ContentType == "image/png"
                    || branchParams.PhotosPhoto.ContentType == "image/x-png"
                    || branchParams.PhotosPhoto.ContentType == "image/pjpeg"))

                {

                    //Getting FileName
                    var fileName = Path.GetFileName(branchParams.PhotosPhoto.FileName);
                    var fileNameWithoutExt = Path.GetFileNameWithoutExtension(branchParams.PhotosPhoto.FileName);

                    //Assigning Unique Filename (Guid)
                    var myUniqueFileName = Convert.ToString(Guid.NewGuid());

                    //Getting file Extension
                    var fileExtension = Path.GetExtension(fileName);

                    // concatenating  FileName + FileExtension
                    newFileNamePhoto = String.Concat("photos/" + myUniqueFileName + "-" + fileNameWithoutExt, fileExtension);

                    // Combines two strings into a path.
                    var filepath =
            new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Uploads"))
            .Root + $@"\{newFileNamePhoto}";

                    using (FileStream fs = System.IO.File.Create(filepath))
                    {
                        branchParams.PhotosPhoto.CopyTo(fs);
                        fs.Flush();
                    }
                }
            }
            branchParams.PhotosImage = newFileNamePhoto;



            var newFileNameTariff = string.Empty;
            if (branchParams.TariffPhoto != null)
            {
                if (branchParams.TariffPhoto.Length > 0 &&
                    (branchParams.TariffPhoto.ContentType == "image/jpeg"
                      || branchParams.TariffPhoto.ContentType == "image/jpg"
                    || branchParams.TariffPhoto.ContentType == "image/png"
                    || branchParams.TariffPhoto.ContentType == "image/x-png"
                    || branchParams.TariffPhoto.ContentType == "image/pjpeg"))

                {

                    //Getting FileName
                    var fileName = Path.GetFileName(branchParams.TariffPhoto.FileName);
                    var fileNameWithoutExt = Path.GetFileNameWithoutExtension(branchParams.TariffPhoto.FileName);

                    //Assigning Unique Filename (Guid)
                    var myUniqueFileName = Convert.ToString(Guid.NewGuid());

                    //Getting file Extension
                    var fileExtension = Path.GetExtension(fileName);

                    // concatenating  FileName + FileExtension
                    newFileNameTariff = String.Concat("tariffs/" + myUniqueFileName + "-" + fileNameWithoutExt, fileExtension);

                    // Combines two strings into a path.
                    var filepath =
            new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Uploads"))
            .Root + $@"\{newFileNameTariff}";

                    using (FileStream fs = System.IO.File.Create(filepath))
                    {
                        branchParams.TariffPhoto.CopyTo(fs);
                        fs.Flush();
                    }
                }
            }
            branchParams.TariffImage = newFileNameTariff;


            Photos photos = new Photos()
            {
                Image = branchParams.PhotosImage,
            };
            await _photosDal.AddAsync(photos);


            Branch branch = new Branch 
            {

                Name = branchParams.Name,
                Description = branchParams.Description,
                LanguageId = branchParams.LanguageId,
                PhotosId = photos.Id

            };

            var allBranch = await _branchDal.AddAsync(branch);
          

            if (allBranch == true)
            {
                Tariff tariff = new Tariff
                {
                    Image = branchParams.TariffImage,
                    BranchId = branch.Id
                };
                await _tariffDal.AddAsync(tariff);
            }

            if (allBranch == true)
            {
                Contact contact = new Contact
                {

                    OurAddress = branchParams.OurAddress,
                    Phone = branchParams.Phone,
                    Email = branchParams.Email,
                    MediaSalesDepartment = branchParams.MediaSalesDepartment,
                    WorkingHours = branchParams.WorkingHours,
                    BranchId = branch.Id,

                };
                await _contactDal.AddAsync(contact);
                
            }      


            return true;
        } 

        public async Task<bool> DeleteBranchAsync(int? id)
        {
            var branch = await _branchDal.GetBranchWithInclude((int)id);
            var contact = await _contactDal.GetContactAsync((int)id);
            var tariff = await _tariffDal.GetTariffAsync((int)id);
            var isDeletedContact = _contactDal.DeleteAsync(contact);
            var isDeletedTariff = _tariffDal.DeleteAsync(tariff);

            if (isDeletedContact.Result)
                await _branchDal.DeleteAsync(branch);

        

            return true;
        }

        public async Task<bool> UpdateBranchAsync(BranchParams branchParams, string oldPhoto)
        {
            if (branchParams == null)
                return false;


            var newFileName = string.Empty;

            if (branchParams.PhotosPhoto != null)
            {
                if (branchParams.PhotosPhoto.Length > 0 &&
                    (branchParams.PhotosPhoto.ContentType == "image/jpeg"
                      || branchParams.PhotosPhoto.ContentType == "image/jpg"
                    || branchParams.PhotosPhoto.ContentType == "image/png"
                    || branchParams.PhotosPhoto.ContentType == "image/x-png"
                    || branchParams.PhotosPhoto.ContentType == "image/pjpeg"))

                {
                    if (oldPhoto != null)
                    {
                        var oldFilePath = Path.Combine(
         _environment.ContentRootPath, "wwwroot", "Uploads", "movies", oldPhoto);
                        if (System.IO.File.Exists(oldFilePath))
                            System.IO.File.Delete(oldFilePath);
                    }

                    //Getting FileName
                    var fileName = Path.GetFileName(branchParams.PhotosPhoto.FileName);
                    var fileNameWithoutExt = Path.GetFileNameWithoutExtension(branchParams.PhotosPhoto.FileName);

                    //Assigning Unique Filename (Guid)
                    var myUniqueFileName = Convert.ToString(Guid.NewGuid());

                    //Getting file Extension
                    var fileExtension = Path.GetExtension(fileName);

                    // concatenating  FileName + FileExtension
                    newFileName = String.Concat("movies/" + myUniqueFileName + "-" + fileNameWithoutExt, fileExtension);

                    // Combines two strings into a path.
                    var filepath =
            new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Uploads"))
            .Root + $@"\{newFileName}";

                    using (FileStream fs = System.IO.File.Create(filepath))
                    {
                        branchParams.PhotosPhoto.CopyTo(fs);
                        fs.Flush();
                    }
                }

                branchParams.PhotosImage = newFileName;
            }
            else
                branchParams.PhotosImage = oldPhoto;
                branchParams.TariffImage = oldPhoto;


            Branch branch = new Branch
            {

                Name = branchParams.Name,
                Description = branchParams.Description,
                LanguageId = branchParams.LanguageId

            };

            var allBranch = await _branchDal.UpdateAsync(branch);
            if (allBranch == true)
            {
                Contact contact = new Contact
                {

                    OurAddress = branchParams.OurAddress,
                    Phone = branchParams.Phone,
                    Email = branchParams.Email,
                    MediaSalesDepartment = branchParams.MediaSalesDepartment,
                    WorkingHours = branchParams.WorkingHours,
                    BranchId = branch.Id,

                };
                await _contactDal.AddAsync(contact);

            }
            if (allBranch == true)
            {
                Tariff tariff = new Tariff
                {

                    Image = branchParams.TariffImage,

                };
                await _tariffDal.AddAsync(tariff);
            }


            return true;

        }
        public async Task<List<Branch>> GetAllBranchAsync(string languageCode)
        {
            return await _branchDal.GetBranchAsync(languageCode);
        }
        public async Task<bool> BranchAnyAsync(Expression<Func<Branch, bool>> expression)
        {
            return await _branchDal.CheckBranch(expression);
        }
        public async Task<Branch> GetBranchAsync(int? id)
        {
            return await _branchDal.GetBranchWithInclude(id.Value);
        }

       
    }
}
