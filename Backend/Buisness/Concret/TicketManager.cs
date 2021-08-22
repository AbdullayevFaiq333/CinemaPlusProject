using Buisness.Abstract;
using DataAccess.Abstract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concret
{
    public class TicketManager : ITicketService
    {
        private readonly ITicketDal _ticketDal;

        public TicketManager(ITicketDal ticketDal)
        {
            _ticketDal = ticketDal;
        }

        public async Task<Ticket> GetTicketWithIdAsync(int id)
        {
            return await _ticketDal.GetAsync(x => x.Id == id);
        }

        public async Task<List<Ticket>> GetAllTicketAsync()
        {
            return await _ticketDal.GetAllAsync();
        }

        public Task<bool> AddTicketAsync(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteTicketAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateTicketAsync(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Ticket>> GetAllTicketAsync(int id)
        {
            return await _ticketDal.GetTicketAsync(id);

        }
        public async Task<bool> TicketAnyAsync(Expression<Func<Ticket, bool>> expression)
        {
            return await _ticketDal.CheckTicket(expression);
        }

        
    }
}
