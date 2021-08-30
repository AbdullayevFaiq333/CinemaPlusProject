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
    public class EFAboutUsBottomPartDal : EFRepositoryBase<AboutUsBottomPart, AppDbContext>, IAboutUsBottomPartDal
    {
        
        public EFAboutUsBottomPartDal(AppDbContext dbContext) : base(dbContext)
        {
        }


        public async Task<bool> CheckAboutUsBottomPart(Expression<Func<AboutUsBottomPart, bool>> expression)
        {
            return await Context.AboutUsBottomParts.AnyAsync(expression);
        }
        public async Task<List<AboutUsBottomPart>> GetAboutUsBottomPartAsync(string languageCode)
        {
            return await Context.AboutUsBottomParts.Include(x => x.Language)
                .Where(x => x.IsDeleted == false && x.Language.Code == languageCode)
                .ToListAsync();
        }
    }
}
