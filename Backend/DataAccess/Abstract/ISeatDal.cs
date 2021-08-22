using Core.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ISeatDal : IRepository<Seat>
    {
        Task<List<Seat>> GetSeatAsync(int id);
        Task<bool> CheckSeat(Expression<Func<Seat, bool>> expression);

    }
}
