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
    public class EFAboutUsHeadPartDal : EFRepositoryBase<AboutUsHeadPart, AppDbContext>, IAboutUsHeadPartDal
    {
        public EFAboutUsHeadPartDal(AppDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<bool> CheckAboutUsHeadPart(Expression<Func<AboutUsHeadPart, bool>> expression)
        {
           
            return await Context.AboutUsHeadParts.AnyAsync(expression);
        }
        public async Task<List<AboutUsHeadPart>> GetAboutUsHeadPartAsync(string languageCode)
        {
           
            return await Context.AboutUsHeadParts.Include(x => x.Language)
                .Where(x=> x.Language.Code == languageCode)
                .ToListAsync();
        }
    }
}
