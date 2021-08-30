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
    public class EFServiceDal : EFRepositoryBase<Service, AppDbContext>, IServiceDal
    {
        public EFServiceDal(AppDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<bool> CheckService(Expression<Func<Service, bool>> expression)
        {
            return await Context.Services.AnyAsync(expression);
        }

        public async Task<List<Service>> GetServiceAsync(string languageCode)
        {
            return await Context.Services.Include(x => x.Language)
                .Where(x => x.Language.Code == languageCode)
                .ToListAsync();
        }
    }
}
