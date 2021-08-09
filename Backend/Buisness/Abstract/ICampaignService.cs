using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface ICampaignService
    {
        Task<Campaign> GetCampaignWithIdAsync(int id);
        Task<List<Campaign>> GetAllCampaignAsync();
        Task<bool> AddCampaignAsync(Campaign campaign);
        Task<bool> UpdateCampaignAsync(Campaign campaign);
        Task<bool> DeleteCampaignAsync(int id);
    }
}
