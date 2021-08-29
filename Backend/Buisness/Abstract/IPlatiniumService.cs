using Core.Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
 
namespace Buisness.Abstract
{
    public interface IPlatiniumService 
    {
        Task<Platinium> GetPlatiniumWithIdAsync(int id);
        Task<List<Platinium>> GetAllPlatiniumAsync();
        Task<List<Platinium>> GetAllPlatiniumAsync(string languageCode); 

        Task<bool> AddPlatiniumAsync(Platinium platinium); 

        Task<bool> UpdatePlatiniumAsync(Platinium platinium,string oldPhoto);
        Task<bool> DeletePlatiniumAsync(Platinium platinium);
        Task<bool> UpdatePlatiniumAsync(Platinium platinium);

        Task<bool> PlatinumAnyAsync(Expression<Func<Platinium, bool>> expression);
    }
}
