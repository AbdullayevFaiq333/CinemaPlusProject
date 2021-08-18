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
    public class AboutUsHeadPartManager : IAboutUsHeadPartService
    {
        private readonly IAboutUsHeadPartDal _aboutUsHeadPartDal;

        public AboutUsHeadPartManager(IAboutUsHeadPartDal aboutUsHeadPartDal)
        {
            _aboutUsHeadPartDal = aboutUsHeadPartDal;
        }

        public async Task<AboutUsHeadPart> GetAboutUsHeadPartWithIdAsync(int id)
        {
            return await _aboutUsHeadPartDal.GetAsync(x => x.Id == id);
        }

        public async Task<List<AboutUsHeadPart>> GetAllAboutUsHeadPartAsync()
        {
            return await _aboutUsHeadPartDal.GetAllAsync();
        }

        public Task<bool> AddAboutUsHeadPartAsync(AboutUsHeadPart aboutUsHeadPart)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAboutUsHeadPartAsync(int id)
        {
            throw new NotImplementedException();
        }


        public Task<bool> UpdateAboutUsHeadPartAsync(AboutUsHeadPart aboutUsHeadPart)
        {
            throw new NotImplementedException();
        }

        public async Task<List<AboutUsHeadPart>> GetAllAboutUsHeadPartAsync(string languageCode)
        {
            return await _aboutUsHeadPartDal.GetAboutUsHeadPartAsync(languageCode);
        }
        public async Task<bool> AboutUsHeadPartAnyAsync(Expression<Func<AboutUsHeadPart, bool>> expression)
        {
            return await _aboutUsHeadPartDal.CheckAboutUsHeadPart(expression);
        }
    }
}
