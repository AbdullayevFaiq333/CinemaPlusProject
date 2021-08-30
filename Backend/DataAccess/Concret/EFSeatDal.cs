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
    public class EFSeatDal : EFRepositoryBase<Seat, AppDbContext>, ISeatDal
    {
        public EFSeatDal(AppDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<bool> CheckSeat(Expression<Func<Seat, bool>> expression)
        {
           
            return await Context.Seats.AnyAsync(expression);
        }

        public async Task<List<Seat>> GetSeatAsync(int id)
        {
            return await Context.Seats.Include(x => x.Row)
                .Where(x => x.RowId == id)
                .ToListAsync();
        }
    }
}
