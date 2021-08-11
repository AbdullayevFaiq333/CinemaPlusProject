using Core.Repository.EFRepository;
using DataAccess.Abstract;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concret
{
    public class EFRowDal : EFRepositoryBase<Row, AppDbContext>, IRowDal
    {
        public async Task<List<Row>> GetRowAsync()
        {
            await using var context = new AppDbContext();
            return await context.Rows.Include(x => x.Seats)
                .ToListAsync();
        }
    }
}
