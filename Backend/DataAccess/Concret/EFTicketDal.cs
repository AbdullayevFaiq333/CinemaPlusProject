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
    public class EFTicketDal : EFRepositoryBase<Ticket, AppDbContext>, ITicketDal
    {
        public async Task<bool> CheckTicket(Expression<Func<Ticket, bool>> expression)
        {
            await using var context = new AppDbContext();
            return await context.Tickets.AnyAsync(expression);
        }

        public async Task<List<Ticket>> GetTicketAsync(int id)
        {
            await using var context = new AppDbContext();
            return await context.Tickets.Include(x => x.Session)
                .Where(x => x.SessionId == id)
                .ToListAsync();
        }
    }
}
