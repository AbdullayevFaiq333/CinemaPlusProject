using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface IRulesService
    {
        Task<Rules> GetRulesWithIdAsync(int id);
        Task<List<Rules>> GetAllRulesAsync();
        Task<bool> AddRulesAsync(Rules rules);
        Task<bool> UpdateRulesAsync(Rules rules);
        Task<bool> DeleteRulesAsync(int id);
    }
}
