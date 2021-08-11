using Buisness.Abstract;
using DataAccess.Abstract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concret
{
    public class SecondNavbarManager : ISecondNavbarService
    {
        private readonly ISecondNavbarDal _secondNavbarDal;

        public SecondNavbarManager(ISecondNavbarDal secondNavbarDal)
        {
            _secondNavbarDal = secondNavbarDal;
        }
        public async Task<SecondNavbar> GetSecondNavbarWithIdAsync(int id)
        {
            return await _secondNavbarDal.GetAsync(x => x.Id == id);
        }

        public async Task<List<SecondNavbar>> GetAllSecondNavbarAsync()
        {
            return await _secondNavbarDal.GetAllAsync();
        }

        public Task<bool> AddSecondNavbarAsync(SecondNavbar secondNavbar)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSecondNavbarAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateSecondNavbarAsync(SecondNavbar secondNavbar)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SecondNavbar>> GetAllSecondNavbarAsync(string languageCode)
        {
            return await _secondNavbarDal.GetSecondNavbarAsync(languageCode);

        }
    }
}
