using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface IAboutUsHeadPartService
    {
        Task<AboutUsHeadPart> GetAboutUsHeadPartWithIdAsync(int id);
        Task<List<AboutUsHeadPart>> GetAllAboutUsHeadPartAsync();
        Task<List<AboutUsHeadPart>> GetAllAboutUsHeadPartAsync(string languageCode);
        Task<bool> AddAboutUsHeadPartAsync(AboutUsHeadPart aboutUsHeadPart);
        Task<bool> UpdateAboutUsHeadPartAsync(AboutUsHeadPart aboutUsHeadPart);
        Task<bool> DeleteAboutUsHeadPartAsync(int id);
    }
}
