using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface IRulesService
    {
        Task<Rules> GetRulesWithIdAsync(int id);
        Task<List<Rules>> GetAllRulesAsync();
        Task<List<Rules>> GetAllRulesAsync(string languageCode);

        Task<bool> AddRulesAsync(Rules rules);
        Task<bool> UpdateRulesAsync(Rules rules);
        Task<bool> DeleteRulesAsync(int id);
        Task<bool> RulesAnyAsync(Expression<Func<Rules, bool>> expression);

    }
}
