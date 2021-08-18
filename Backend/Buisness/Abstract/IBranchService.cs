using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface IBranchService
    {
        Task<Branch> GetBranchWithIdAsync(int id);
        Task<List<Branch>> GetAllBranchAsync();
        Task<List<Branch>> GetAllBranchAsync(string languageCode);
        Task<bool> AddBranchAsync(Branch branch);
        Task<bool> UpdateBranchAsync(Branch branch);
        Task<bool> DeleteBranchAsync(int id);
        Task<bool> BranchAnyAsync(Expression<Func<Branch, bool>> expression);

    }
}
