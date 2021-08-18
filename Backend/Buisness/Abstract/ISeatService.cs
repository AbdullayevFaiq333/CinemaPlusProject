using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface ISeatService
    {
        Task<Seat> GetSeatWithIdAsync(int id);
        Task<List<Seat>> GetAllSeatAsync();
        Task<bool> AddSeatAsync(Seat seat);
        Task<bool> UpdateSeatAsync(Seat seat);
        Task<bool> DeleteSeatAsync(int id);
        Task<bool> SeatAnyAsync(Expression<Func<Seat, bool>> expression);

    }
}
