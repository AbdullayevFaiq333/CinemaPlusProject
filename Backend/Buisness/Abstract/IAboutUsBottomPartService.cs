using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface IAboutUsBottomPartService
    {
        Task<AboutUsBottomPart> GetAboutUsBottomPartWithIdAsync(int id);
        Task<List<AboutUsBottomPart>> GetAllAboutUsBottomPartAsync();
        Task<List<AboutUsBottomPart>> GetAllAboutUsBottomPartAsync(string languageCode);
        Task<bool> AddAboutUsBottomPartAsync(AboutUsBottomPart aboutUsBottomPart);
        Task<bool> UpdateAboutUsBottomPartAsync(AboutUsBottomPart aboutUsBottomPart);
        Task<bool> DeleteAboutUsBottomPartAsync(int id);
        Task<bool> AboutUsBottomPartAnyAsync(Expression<Func<AboutUsBottomPart, bool>> expression);

    }
}
