using Core.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ITicketDal : IRepository<Ticket>
    {
        Task<List<Ticket>> GetTicketAsync(int id);

        Task<bool> CheckTicket(Expression<Func<Ticket, bool>> expression);

    }
}
