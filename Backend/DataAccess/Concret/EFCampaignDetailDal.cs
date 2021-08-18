using Core.Repository.EFRepository;
using DataAccess.Abstract;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concret
{
    public class EFCampaignDetailDal : EFRepositoryBase<CampaignDetail, AppDbContext>, ICampaignDetailDal
    {
        public async Task<bool> CheckCampaignDetail(Expression<Func<CampaignDetail, bool>> expression)
        {
            await using var context = new AppDbContext();
            return await context.CampaignDetails.AnyAsync(expression);
        }
        public async Task<CampaignDetail> GetCampaignDetailAsync(string languageCode, int id)
        {
            await using var context = new AppDbContext();
            return await context.CampaignDetails.Include(x => x.Language)
                .Where(x => x.Language.Code == languageCode)
                .Include(x => x.Campaign)
                .Where(x => x.CampaignId == id)
                .FirstOrDefaultAsync();
        }

        
    }
}
