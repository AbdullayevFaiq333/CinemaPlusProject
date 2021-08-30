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
    public class EFFooterDal : EFRepositoryBase<Footer, AppDbContext>, IFooterDal
    {
        public EFFooterDal(AppDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<bool> CheckFooter(Expression<Func<Footer, bool>> expression)
        {
            return await Context.Footers.AnyAsync(expression);
        }
        public async Task<List<Footer>> GetFooterAsync(string languageCode)
        {
            return await Context.Footers.Include(x => x.Language)
                .Where(x => x.Language.Code == languageCode)
                .ToListAsync();
        }
    }
}
