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
    public class EFBranchDal : EFRepositoryBase<Branch, AppDbContext>, IBranchDal
    {
        public async Task<List<Branch>> GetBranchAsync(string languageCode,int id)
        {
            await using var context = new AppDbContext();
            return await context.Branches.Include(x => x.Language)
                .Where(x => x.Language.Code == languageCode).Include(x => x.Photos)
                .Where(x => x.Photos.Id == id).Include(x=>x.Tariff).Where(x=>x.Tariff.Id==id)
                .Include(x=>x.Contact).Where(x=>x.Contact.Id==id)
                .ToListAsync();
        }
    }
}
