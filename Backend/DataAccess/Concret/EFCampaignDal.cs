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
    public class EFCampaignDal : EFRepositoryBase<Campaign, AppDbContext>, ICampaignDal
    {
        public EFCampaignDal(AppDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<bool> CheckCampaign(Expression<Func<Campaign, bool>> expression)
        {
            return await Context.Campaigns.AnyAsync(expression);
        }
        public async Task<List<Campaign>> GetCampaignAsync(string languageCode)
        {
            return await Context.Campaigns.Include(x => x.Language)
                .Where(x => x.Language.Code == languageCode)
                .ToListAsync();
        }
    }
}
