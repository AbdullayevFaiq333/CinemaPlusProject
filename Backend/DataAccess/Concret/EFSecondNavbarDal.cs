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
    public class EFSecondNavbarDal : EFRepositoryBase<SecondNavbar, AppDbContext>, ISecondNavbarDal
    {
        public async Task<bool> CheckSecondNavbar(Expression<Func<SecondNavbar, bool>> expression)
        {
            await using var context = new AppDbContext();
            return await context.SecondNavbars.AnyAsync(expression);
        }
        public async Task<List<SecondNavbar>> GetSecondNavbarAsync(string languageCode)
        {
            await using var context = new AppDbContext();
            return await context.SecondNavbars.Include(x => x.Language)
                .Where(x => x.Language.Code == languageCode)
                .ToListAsync();
        }
    }
}
