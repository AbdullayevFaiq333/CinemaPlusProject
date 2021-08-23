using Buisness.Abstract;
using DataAccess.Abstract;
using Entities.Models;
using Microsoft.Extensions.FileProviders;
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

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
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

        public Task<bool> DeleteServiceAsync(Service service)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateServiceAsync(Service service)
        {
            throw new NotImplementedException();
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
