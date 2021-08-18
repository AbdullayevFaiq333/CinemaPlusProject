using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface IFAQService
    {
        Task<FAQ> GetFAQWithIdAsync(int id);
        Task<List<FAQ>> GetAllFAQAsync();
        Task<List<FAQ>> GetAllFAQAsync(string languageCode);
        Task<bool> AddFAQAsync(FAQ fAQ);
        Task<bool> UpdateFAQAsync(FAQ fAQ);
        Task<bool> DeleteFAQAsync(int id);
        Task<bool> FAQAnyAsync(Expression<Func<FAQ, bool>> expression);

    }
}
