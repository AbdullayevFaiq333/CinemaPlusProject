using Buisness.Abstract;
using DataAccess.Abstract;
using Entities.Models;
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
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDal _serviceDal;
        private readonly IHostEnvironment _environment;

        public ServiceManager(IServiceDal serviceDal, IHostEnvironment environment)
        {
            _serviceDal = serviceDal;
            _environment = environment;
        }
        public async Task<Service> GetServiceWithIdAsync(int id)
        {
            return await _serviceDal.GetAsync(x => x.Id == id);
        }

        public async Task<List<Service>> GetAllServiceAsync()
        {
            return await _serviceDal.GetAllAsync();
        }

        public async Task<bool> AddServiceAsync(Service service)
        {
            if (service == null)
                return false;


            var newFileName = string.Empty;

            if (service.Photo != null)
            {
                if (service.Photo.Length > 0 &&
                    (service.Photo.ContentType == "image/jpeg" 
                      || service.Photo.ContentType == "image/jpg"
                    || service.Photo.ContentType == "image/png"
                    || service.Photo.ContentType == "image/x-png"
                    || service.Photo.ContentType == "image/pjpeg"))

                {

                    //Getting FileName
                    var fileName = Path.GetFileName(service.Photo.FileName);
                    var fileNameWithoutExt = Path.GetFileNameWithoutExtension(service.Photo.FileName);

                    //Assigning Unique Filename (Guid)
                    var myUniqueFileName = Convert.ToString(Guid.NewGuid());

                    //Getting file Extension
                    var fileExtension = Path.GetExtension(fileName);

                    // concatenating  FileName + FileExtension 
                    newFileName = String.Concat("services/" + myUniqueFileName + "-" + fileNameWithoutExt, fileExtension);

                    // Combines two strings into a path.
                    var filepath =
            new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Uploads"))
            .Root + $@"\{newFileName}";

                    using (FileStream fs = System.IO.File.Create(filepath))
                    {
                        service.Photo.CopyTo(fs);
                        fs.Flush();
                    }
                }
            }

            service.Icon = newFileName;

            await _serviceDal.AddAsync(service);
            return true;

        }

        public async Task<bool> DeleteServiceAsync(Service service)
        {
            return await _serviceDal.DeleteAsync(service);

        }

        public async Task<bool> UpdateServiceAsync(Service service, string oldPhoto)
        {          


            var newFileName = string.Empty;

            if (service.Photo != null)
            {
                if (service.Photo.Length > 0 &&
                    (service.Photo.ContentType == "image/jpeg"
                      || service.Photo.ContentType == "image/jpg"
                    || service.Photo.ContentType == "image/png"
                    || service.Photo.ContentType == "image/x-png"
                    || service.Photo.ContentType == "image/pjpeg"))

                {
                    if (oldPhoto != null)
                    {
                        var oldFilePath = Path.Combine(
        _environment.ContentRootPath, "wwwroot", "Uploads", "service", oldPhoto);
                        if (System.IO.File.Exists(oldFilePath))
                            System.IO.File.Delete(oldFilePath);
                    }
                    //Getting FileName
                    var fileName = Path.GetFileName(service.Photo.FileName);
                    var fileNameWithoutExt = Path.GetFileNameWithoutExtension(service.Photo.FileName);

                    //Assigning Unique Filename (Guid)
                    var myUniqueFileName = Convert.ToString(Guid.NewGuid());

                    //Getting file Extension
                    var fileExtension = Path.GetExtension(fileName);

                    // concatenating  FileName + FileExtension
                    newFileName = String.Concat("services/" + myUniqueFileName + "-" + fileNameWithoutExt, fileExtension);

                    // Combines two strings into a path.
                    var filepath =
            new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Uploads"))
            .Root + $@"\{newFileName}";

                    using (FileStream fs = System.IO.File.Create(filepath))
                    {
                        service.Photo.CopyTo(fs);
                        fs.Flush();
                    }
                }
                service.Icon = newFileName;

                await _serviceDal.UpdateAsync(service);
                return true;
            }
            return false;

        }

        public async Task<List<Service>> GetAllServiceAsync(string languageCode)
        {
            return await _serviceDal.GetServiceAsync(languageCode);

        }
        public async Task<bool> ServiceAnyAsync(Expression<Func<Service, bool>> expression)
        {
            return await _serviceDal.CheckService(expression);
        }
    } 
}
