using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface IHallService
    {
        Task<Hall> GetHallWithIdAsync(int id);
        Task<List<Hall>> GetAllHallAsync();
        Task<bool> AddHallAsync(Hall hall);
        Task<bool> UpdateHallAsync(Hall hall);
        Task<bool> DeleteHallAsync(int id);
    }
}
