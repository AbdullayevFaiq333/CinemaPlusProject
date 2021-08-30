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
    public class EFPlatiniumDal : EFRepositoryBase<Platinium, AppDbContext>, IPlatiniumDal 
    {
        public EFPlatiniumDal(AppDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<bool> CheckPlatinumItem(Expression<Func<Platinium, bool>> expression)
        {
            
            return await Context.Platiniums.AnyAsync(expression);
        }

        public async Task<List<Platinium>> GetPlatiniumAsync(string languageCode)
        {
            return await Context.Platiniums.Include(x => x.Language)
                .Where(x => x.IsDeleted == false && x.Language.Code == languageCode)
                .ToListAsync();
        }
    }
}
