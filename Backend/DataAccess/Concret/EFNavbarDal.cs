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
    public class EFNavbarDal : EFRepositoryBase<Navbar, AppDbContext>, INavbarDal
    {
        public EFNavbarDal(AppDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<bool> CheckNavbar(Expression<Func<Navbar, bool>> expression)
        {
            return await Context.Navbars.AnyAsync(expression);
        }
        public async Task<List<Navbar>> GetNavbarAsync(string languageCode)
        {
            return await Context.Navbars.Include(x => x.Language)
                .Where(x => x.Language.Code == languageCode)
                .ToListAsync();
        }
    }
}
