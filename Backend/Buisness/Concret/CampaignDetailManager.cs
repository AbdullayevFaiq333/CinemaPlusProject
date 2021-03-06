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
    public class CampaignDetailManager : ICampaignDetailService
    {
        private readonly ICampaignDetailDal _campaignDetailDal;

        public CampaignDetailManager(ICampaignDetailDal campaignDetailDal)
        {
            _campaignDetailDal = campaignDetailDal;
        }

        public async Task<CampaignDetail> GetCampaignDetailWithIdAsync(int id)
        {
            return await _campaignDetailDal.GetAsync(x => x.Id == id);
        }

        public async Task<List<CampaignDetail>> GetAllCampaignDetailAsync()
        {
            return await _campaignDetailDal.GetAllAsync();
        }

        public Task<bool> AddCampaignDetailAsync(CampaignDetail campaignDetail)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCampaignDetailAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCampaignDetailAsync(CampaignDetail campaignDetail)
        {
            throw new NotImplementedException();
        }

        public async Task<CampaignDetail> GetAllCampaignDetailAsync(string languageCode,int id)
        {
            return await _campaignDetailDal.GetCampaignDetailAsync(languageCode,id);
        }

        public async Task<bool> CampaignDetailAnyAsync(Expression<Func<CampaignDetail, bool>> expression)
        {
            return await _campaignDetailDal.CheckCampaignDetail(expression);
        }
    }
}
