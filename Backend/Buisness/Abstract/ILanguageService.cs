using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface ILanguageService
    {
        Task<Language> GetLanguageWithIdAsync(int id);
        Task<List<Language>> GetAllLanguageAsync();
        Task<bool> AddLanguageAsync(Language language);
        Task<bool> UpdateLanguageAsync(Language language);
        Task<bool> DeleteLanguageAsync(int id);
        Task<bool> LanguageAnyAsync(Expression<Func<Language, bool>> expression);

    }
}
