using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface ICampaignDetailService
    {
        Task<CampaignDetail> GetCampaignDetailWithIdAsync(int id);
        Task<List<CampaignDetail>> GetAllCampaignDetailAsync();
        Task<bool> AddCampaignDetailAsync(CampaignDetail campaignDetail);
        Task<bool> UpdateCampaignDetailAsync(CampaignDetail campaignDetail);
        Task<bool> DeleteCampaignDetailAsync(int id);
    }
}
