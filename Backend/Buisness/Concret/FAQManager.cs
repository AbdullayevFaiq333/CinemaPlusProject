using Buisness.Abstract;
using DataAccess.Abstract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concret
{
    public class FAQManager : IFAQService
    {
        private readonly IFAQDal _fAQDal;

        public FAQManager(IFAQDal fAQDal)
        {
            _fAQDal = fAQDal;
        }
        public async Task<FAQ> GetFAQWithIdAsync(int id)
        {
            return await _fAQDal.GetAsync(x => x.Id == id);
        }

        public async Task<List<FAQ>> GetAllFAQAsync()
        {
            return await _fAQDal.GetAllAsync();
        }

        public Task<bool> AddFAQAsync(FAQ fAQ)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteFAQAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateFAQAsync(FAQ fAQ)
        {
            throw new NotImplementedException();
        }

        public async Task<List<FAQ>> GetAllFAQAsync(string languageCode)
        {
            return await _fAQDal.GetFAQAsync(languageCode);
        }
    }
}
