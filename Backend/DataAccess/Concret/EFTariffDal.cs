using Core.Repository.EFRepository;
using DataAccess.Abstract;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concret
{
    public class EFTariffDal : EFRepositoryBase<Tariff, AppDbContext>, ITariffDal
    {
        public async Task<Tariff> GetTariffAsync(int id)
        {
            await using var context = new AppDbContext();
            return await context.Tariffs
                .Include(x => x.Branch)
                .Where(x => x.BranchId == id)
                .FirstOrDefaultAsync();
        }
    }
}
