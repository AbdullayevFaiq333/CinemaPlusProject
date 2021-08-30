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
        public EFRulesDal(AppDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<bool> CheckRules(Expression<Func<Rules, bool>> expression)
        {
            return await Context.Rules.AnyAsync(expression);
        }
        public async Task<List<Rules>> GetRulesAsync(string languageCode)
        {
            return await Context.Rules.Include(x => x.Language)
                .Where(x => x.Language.Code == languageCode)
                .ToListAsync();
        }
    }
}
