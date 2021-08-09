using Buisness.Abstract;
using DataAccess.Abstract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concret
{
    public class CampaignManager : ICampaignService
    {
        private readonly ICampaignDal _campaignDal;

        public CampaignManager(ICampaignDal campaignDal)
        {
            _campaignDal = campaignDal;
        }

        public async Task<Campaign> GetCampaignWithIdAsync(int id)
        {
            return await _campaignDal.GetAsync(x => x.Id == id);
        }

        public async Task<List<Campaign>> GetAllCampaignAsync()
        {
            return await _campaignDal.GetAllAsync();
        }

        public Task<bool> AddCampaignAsync(Campaign campaign)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCampaignAsync(int id)
        {
            throw new NotImplementedException();
        }


        public Task<bool> UpdateCampaignAsync(Campaign campaign)
        {
            throw new NotImplementedException();
        }
    }
}
