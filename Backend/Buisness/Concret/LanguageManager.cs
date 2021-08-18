using Buisness.Abstract;
using DataAccess.Abstract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concret
{
    public class LanguageManager : ILanguageService
    {
        private readonly ILanguageDal _languageDal;

        public LanguageManager(ILanguageDal languageDal)
        {
            _languageDal = languageDal;
        }
        public async Task<Language> GetLanguageWithIdAsync(int id)
        {
            return await _languageDal.GetAsync(x => x.Id == id);
        }

        public async Task<List<Language>> GetAllLanguageAsync()
        {
            return await _languageDal.GetAllAsync();
        }

        public Task<bool> AddLanguageAsync(Language language)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteLanguageAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateLanguageAsync(Language language)
        {
            throw new NotImplementedException();
        }
        public async Task<bool> LanguageAnyAsync(Expression<Func<Language, bool>> expression)
        {
            return await _languageDal.CheckLanguage(expression);
        }
    }
}
