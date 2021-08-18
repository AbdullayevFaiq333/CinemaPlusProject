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
    public class EFBranchDal : EFRepositoryBase<Branch, AppDbContext>, IBranchDal
    {
        public async Task<bool> CheckBranch(Expression<Func<Branch, bool>> expression)
        {
            await using var context = new AppDbContext();
            return await context.Branches.AnyAsync(expression);
        }
        public async Task<List<Branch>> GetBranchAsync(string languageCode)
        {
            await using var context = new AppDbContext();
            return await context.Branches.Include(x => x.Language)
                .Include(x => x.Photos).Include(x=>x.Tariff).Include(x=>x.Contact)
                .Where(x => x.Language.Code == languageCode)
                .ToListAsync();
        }
    }
}
