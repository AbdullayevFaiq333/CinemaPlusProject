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
    public class SeatManager : ISeatService
    {
        private readonly ISeatDal _seatDal;

        public SeatManager(ISeatDal seatDal)
        {
            _seatDal = seatDal;
        }
        public async Task<Seat> GetSeatWithIdAsync(int id)
        {
            return await _seatDal.GetAsync(x => x.Id == id);
        }

        public async Task<List<Seat>> GetAllSeatAsync()
        {
            return await _seatDal.GetAllAsync();
        }

        public Task<bool> AddSeatAsync(Seat seat)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSeatAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateSeatAsync(Seat seat)
        {
            throw new NotImplementedException();
        }
        public async Task<bool> SeatAnyAsync(Expression<Func<Seat, bool>> expression)
        {
            return await _seatDal.CheckSeat(expression);
        }
    }
}
