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
    public class FooterManager : IFooterService
    {
        private readonly IFooterDal _footerDal;

        public FooterManager(IFooterDal footerDal)
        {
            _footerDal = footerDal;
        }
        public async Task<Footer> GetFooterWithIdAsync(int id)
        {
            return await _footerDal.GetAsync(x => x.Id == id);
        }

        public async Task<List<Footer>> GetAllFooterAsync()
        {
            return await _footerDal.GetAllAsync();
        }

        public Task<bool> AddFooterAsync(Footer footer)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteFooterAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateFooterAsync(Footer footer)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Footer>> GetAllFooterAsync(string languageCode)
        {
            return await _footerDal.GetFooterAsync(languageCode);
        }
        public async Task<bool> FooterAnyAsync(Expression<Func<Footer, bool>> expression)
        {
            return await _footerDal.CheckFooter(expression);
        }
    }
}
