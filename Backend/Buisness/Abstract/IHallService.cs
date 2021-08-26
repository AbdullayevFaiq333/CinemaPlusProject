using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface IHallService
    {
        Task<Hall> GetHallWithIdAsync(int id);
        Task<List<Hall>> GetAllHallAsync();
        Task<Hall> GetAllHallAsync(string languageCode,int id);

        Task<bool> AddHallAsync(Hall hall);
        Task<bool> UpdateHallAsync(Hall hall);
        Task<bool> DeleteHallAsync(int id);
        Task<bool> HallAnyAsync(Expression<Func<Hall, bool>> expression);

    }
}
