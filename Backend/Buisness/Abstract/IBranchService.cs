using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface IBranchService
    {
        Task<Branch> GetBranchWithIdAsync(int id);
        Task<List<Branch>> GetAllBranchAsync();
        Task<List<Branch>> GetAllBranchAsync(string languageCode,int id);
        Task<bool> AddBranchAsync(Branch branch);
        Task<bool> UpdateBranchAsync(Branch branch);
        Task<bool> DeleteBranchAsync(int id);
    }
}
