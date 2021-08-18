using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface ICampaignDetailService
    {
        Task<CampaignDetail> GetCampaignDetailWithIdAsync(int id);
        Task<List<CampaignDetail>> GetAllCampaignDetailAsync();
        Task<CampaignDetail> GetAllCampaignDetailAsync(string languageCode, int id);
       
        Task<bool> AddCampaignDetailAsync(CampaignDetail campaignDetail);
        Task<bool> UpdateCampaignDetailAsync(CampaignDetail campaignDetail);
        Task<bool> DeleteCampaignDetailAsync(int id);
        Task<bool> CampaignDetailAnyAsync(Expression<Func<CampaignDetail, bool>> expression);

    }
}
