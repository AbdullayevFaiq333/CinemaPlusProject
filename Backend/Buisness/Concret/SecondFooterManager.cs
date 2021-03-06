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
    public class SecondFooterManager : ISecondFooterService
    {
        private readonly ISecondFooterDal _secondFooterDal;

        public SecondFooterManager(ISecondFooterDal secondFooterDal)
        {
            _secondFooterDal = secondFooterDal;
        }
        public async Task<SecondFooter> GetSecondFooterWithIdAsync(int id)
        {
            return await _secondFooterDal.GetAsync(x => x.Id == id);
        }

        public async Task<List<SecondFooter>> GetAllSecondFooterAsync()
        {
            return await _secondFooterDal.GetAllAsync();
        }

        public Task<bool> AddSecondFooterAsync(SecondFooter secondFooter)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSecondFooterAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateSecondFooterAsync(SecondFooter secondFooter)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SecondFooter>> GetAllSecondFooterAsync(string languageCode)
        {
            return await _secondFooterDal.GetSecondFooterAsync(languageCode);

        }
        public async Task<bool> SecondFooterAnyAsync(Expression<Func<SecondFooter, bool>> expression)
        {
            return await _secondFooterDal.CheckSecondFooter(expression);
        }
    }
}
