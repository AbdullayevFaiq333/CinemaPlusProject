using Core.Repository.EFRepository;
using DataAccess.Abstract;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concret
{
    public class EFCampaignDal : EFRepositoryBase<Campaign, AppDbContext>, ICampaignDal
    {
        public async Task<List<Campaign>> GetCampaignAsync(string languageCode)
        {
            await using var context = new AppDbContext();
            return await context.Campaigns.Include(x => x.Language)
                .Where(x => x.Language.Code == languageCode)
                .ToListAsync();
        }
    }
}
