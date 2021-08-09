using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface IPlatiniumService
    {
        Task<Platinium> GetPlatiniumWithIdAsync(int id);
        Task<List<Platinium>> GetAllPlatiniumAsync();
        Task<bool> AddPlatiniumAsync(Platinium platinium);
        Task<bool> UpdatePlatiniumAsync(Platinium platinium);
        Task<bool> DeletePlatiniumAsync(int id);
    }
}
