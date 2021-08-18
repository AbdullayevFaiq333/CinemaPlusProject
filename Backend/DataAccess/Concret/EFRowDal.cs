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
    public class EFRowDal : EFRepositoryBase<Row, AppDbContext>, IRowDal
    {
        public async Task<bool> CheckRow(Expression<Func<Row, bool>> expression)
        {
            await using var context = new AppDbContext();
            return await context.Rows.AnyAsync(expression);
        }
        public async Task<List<Row>> GetRowAsync()
        {
            await using var context = new AppDbContext();
            return await context.Rows.Include(x => x.Seats)
                .ToListAsync();
        }
    }
}
