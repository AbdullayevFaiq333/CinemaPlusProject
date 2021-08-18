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
    public class EFSeatDal : EFRepositoryBase<Seat, AppDbContext>, ISeatDal
    {
        public async Task<bool> CheckSeat(Expression<Func<Seat, bool>> expression)
        {
            await using var context = new AppDbContext();
            return await context.Seats.AnyAsync(expression);
        }
    }
}
