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
        public async Task<bool> CheckLanguage(Expression<Func<Language, bool>> expression)
        {
            await using var context = new AppDbContext();
            return await context.Languages.AnyAsync(expression);
        }
    }
}
