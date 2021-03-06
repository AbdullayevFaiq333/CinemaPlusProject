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
        public EFCampaignDetailDal(AppDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<bool> CheckCampaignDetail(Expression<Func<CampaignDetail, bool>> expression)
        {
            return await Context.CampaignDetails.AnyAsync(expression);
        }
        public async Task<CampaignDetail> GetCampaignDetailAsync(string languageCode, int id)
        {
            
            return await Context.CampaignDetails.Include(x => x.Language)
                .Where(x => x.Language.Code == languageCode)
                .Include(x => x.Campaign)
                .Where(x => x.CampaignId == id)
                .FirstOrDefaultAsync();
        }

        
    }
}
