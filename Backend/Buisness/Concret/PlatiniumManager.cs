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
    public class PlatiniumManager : IPlatiniumService
    { 
        private readonly IPlatiniumDal _platiniumDal;

        public PlatiniumManager(IPlatiniumDal platiniumDal)
        {
            _platiniumDal = platiniumDal;
        }
        public async Task<Platinium> GetPlatiniumWithIdAsync(int id)
        {
            return await _platiniumDal.GetAsync(x => x.Id == id);
        }

        public async Task<List<Platinium>> GetAllPlatiniumAsync()
        {
            return await _platiniumDal.GetAllAsync(w=>w.IsDeleted == false);
        }

        public async Task<bool> AddPlatiniumAsync(Platinium platinium) 
        {
            if (platinium == null)
                return false;


            var newFileName = string.Empty;

            if (platinium.Photo != null)
            {
                if (platinium.Photo.Length > 0 &&
                    (platinium.Photo.ContentType == "image/jpeg" 
                      || platinium.Photo.ContentType == "image/jpg"
                    || platinium.Photo.ContentType == "image/png"
                    || platinium.Photo.ContentType == "image/x-png"
                    || platinium.Photo.ContentType == "image/pjpeg"))

                {

                    //Getting FileName
                    var fileName = Path.GetFileName(platinium.Photo.FileName);
                    var fileNameWithoutExt = Path.GetFileNameWithoutExtension(platinium.Photo.FileName);

                    //Assigning Unique Filename (Guid)
                    var myUniqueFileName = Convert.ToString(Guid.NewGuid());

                    //Getting file Extension
                    var fileExtension = Path.GetExtension(fileName);

                    // concatenating  FileName + FileExtension 
                    newFileName = String.Concat("platinium/" + myUniqueFileName + "-" + fileNameWithoutExt, fileExtension);

                    // Combines two strings into a path.
                    var filepath =
            new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Uploads"))
            .Root + $@"\{newFileName}";

                    using (FileStream fs = System.IO.File.Create(filepath))
                    {
                        platinium.Photo.CopyTo(fs);
                        fs.Flush();
                    }
                }
            }

            platinium.Icon = newFileName;

            await _platiniumDal.AddAsync(platinium);
            return true;
        }

        public async Task<bool> DeletePlatiniumAsync(Platinium platinium)
        {
            return await _platiniumDal.DeleteAsync(platinium);
        }

        public async Task<bool> UpdatePlatiniumAsync(Platinium platinium)
        {
            return await _platiniumDal.UpdateAsync(platinium);

        }

        public async Task<List<Platinium>> GetAllPlatiniumAsync(string languageCode)
        {
            return await _platiniumDal.GetPlatiniumAsync(languageCode);

        }
      
        public async Task<bool> PlatinumAnyAsync(Expression<Func<Platinium, bool>> expression)
        {
            return await _platiniumDal.CheckPlatinumItem(expression);
        }
    }
}
