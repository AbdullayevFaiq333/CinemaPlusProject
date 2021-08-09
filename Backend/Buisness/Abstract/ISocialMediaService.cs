using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface ISocialMediaService
    {
        Task<SocialMedia> GetSocialMediaWithIdAsync(int id);
        Task<List<SocialMedia>> GetAllSocialMediaAsync();
        Task<bool> AddSocialMediaAsync(SocialMedia socialMedia);
        Task<bool> UpdateSocialMediaAsync(SocialMedia socialMedia);
        Task<bool> DeleteSocialMediaAsync(int id);
    }
}
