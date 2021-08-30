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
    public class EFTariffDal : EFRepositoryBase<Tariff, AppDbContext>, ITariffDal
    {
        public EFTariffDal(AppDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<bool> CheckTariff(Expression<Func<Tariff, bool>> expression)
        {
            return await Context.Tariffs.AnyAsync(expression);
        }
        public async Task<Tariff> GetTariffAsync(int id)
        {
            return await Context.Tariffs
                .Include(x => x.Branch)
                .Where(x => x.BranchId == id)
                .FirstOrDefaultAsync();
        }
    }
}
