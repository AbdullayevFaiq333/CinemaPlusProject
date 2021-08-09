using Buisness.Abstract;
using DataAccess.Abstract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concret
{
    public class AboutUsBottomPartManager : IAboutUsBottomPartService
    {
        private readonly IAboutUsBottomPartDal _aboutUsBottomPartDal;

        public AboutUsBottomPartManager(IAboutUsBottomPartDal aboutUsBottomPartDal)
        {
            _aboutUsBottomPartDal = aboutUsBottomPartDal;
        }

        public async Task<AboutUsBottomPart> GetAboutUsBottomPartWithIdAsync(int id)
        {
            return await _aboutUsBottomPartDal.GetAsync(x => x.Id == id);
        }

        public async Task<List<AboutUsBottomPart>> GetAllAboutUsBottomPartAsync()
        {
            return await _aboutUsBottomPartDal.GetAllAsync();
        }

        public Task<bool> AddAboutUsBottomPartAsync(AboutUsBottomPart aboutUsBottomPart)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAboutUsBottomPartAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAboutUsBottomPartAsync(AboutUsBottomPart aboutUsBottomPart)
        {
            throw new NotImplementedException();
        }

        public async Task<List<AboutUsBottomPart>> GetAllAboutUsBottomPartAsync(string languageCode)
        {
            return await _aboutUsBottomPartDal.GetAboutUsBottomPartAsync(languageCode);
        }
    }
}
