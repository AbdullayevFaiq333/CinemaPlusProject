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
    public class EFRulesDal : EFRepositoryBase<Rules, AppDbContext>, IRulesDal
    {
        public async Task<bool> CheckRules(Expression<Func<Rules, bool>> expression)
        {
            await using var context = new AppDbContext();
            return await context.Rules.AnyAsync(expression);
        }
        public async Task<List<Rules>> GetRulesAsync(string languageCode)
        {
            await using var context = new AppDbContext();
            return await context.Rules.Include(x => x.Language)
                .Where(x => x.Language.Code == languageCode)
                .ToListAsync();
        }
    }
}
