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
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }
        public async Task<SocialMedia> GetSocialMediaWithIdAsync(int id)
        {
            return await _socialMediaDal.GetAsync(x => x.Id == id);
        }

        public async Task<List<SocialMedia>> GetAllSocialMediaAsync()
        {
            return await _socialMediaDal.GetAllAsync();
        }

        public Task<bool> AddSocialMediaAsync(SocialMedia socialMedia)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSocialMediaAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateSocialMediaAsync(SocialMedia socialMedia)
        {
            throw new NotImplementedException();
        }
        public async Task<bool> SocialMediaAnyAsync(Expression<Func<SocialMedia, bool>> expression)
        {
            return await _socialMediaDal.CheckSocialMedia(expression);
        }
    }
}
