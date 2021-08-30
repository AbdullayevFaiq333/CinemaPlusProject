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
    public class EFFAQDal : EFRepositoryBase<FAQ, AppDbContext>, IFAQDal
    {
        public EFFAQDal(AppDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<bool> CheckFAQ(Expression<Func<FAQ, bool>> expression)
        {
            return await Context.FAQs.AnyAsync(expression);
        }
        public async Task<List<FAQ>> GetFAQAsync(string languageCode)
        {
            return await Context.FAQs.Include(x => x.Language)
                .Where(x => x.Language.Code == languageCode)
                .ToListAsync();
        }
    }
}
