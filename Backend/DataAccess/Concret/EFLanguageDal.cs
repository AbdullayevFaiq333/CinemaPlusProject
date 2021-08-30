using Core.Repository.EFRepository;
using DataAccess.Abstract;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concret
{
    public class EFLanguageDal : EFRepositoryBase<Language, AppDbContext>, ILanguageDal
    {
        public EFLanguageDal(AppDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<bool> CheckLanguage(Expression<Func<Language, bool>> expression)
        {
            return await Context.Languages.AnyAsync(expression);
        }
    }
}
