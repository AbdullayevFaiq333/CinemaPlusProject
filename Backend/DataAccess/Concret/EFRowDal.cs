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
    public class EFRowDal : EFRepositoryBase<Row, AppDbContext>, IRowDal
    {
        public EFRowDal(AppDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<bool> CheckRow(Expression<Func<Row, bool>> expression)
        {
            return await Context.Rows.AnyAsync(expression);
        }
        public async Task<List<Row>> GetRowAsync(int id)
        {
            return await Context.Rows.Include(x => x.Seats).Include(x=>x.Hall)
                .Where(x => x.HallId == id)
                .ToListAsync();
        }
    }
}
