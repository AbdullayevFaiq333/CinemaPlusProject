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
    public class EFSecondFooterDal : EFRepositoryBase<SecondFooter, AppDbContext>, ISecondFooterDal
    {
        public EFSecondFooterDal(AppDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<bool> CheckSecondFooter(Expression<Func<SecondFooter, bool>> expression)
        {
            return await Context.SecondFooters.AnyAsync(expression);
        }
        public async Task<List<SecondFooter>> GetSecondFooterAsync(string languageCode)
        {
            return await Context.SecondFooters.Include(x => x.Language)
                .Where(x => x.Language.Code == languageCode)
                .ToListAsync();
        }
    }
}
