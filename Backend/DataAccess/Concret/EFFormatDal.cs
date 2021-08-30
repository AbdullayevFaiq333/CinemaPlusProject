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
    public class EFFormatDal : EFRepositoryBase<Format, AppDbContext>, IFormatDal
    {
        public EFFormatDal(AppDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<bool> CheckFormat(Expression<Func<Format, bool>> expression)
        {
            return await Context.Formats.AnyAsync(expression);
        }
        public async Task<List<Format>> GetFormatAsync(string languageCode)
        {
            return await Context.Formats.Include(x => x.Language)
                .Where(x => x.Language.Code == languageCode)
                .ToListAsync();
        }
    }
}
