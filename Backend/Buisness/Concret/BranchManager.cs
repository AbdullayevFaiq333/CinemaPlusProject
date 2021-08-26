using Buisness.Abstract;
using DataAccess.Abstract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concret
{
    public class BranchManager : IBranchService
    {
        private readonly IBranchDal _branchDal;
         
        public BranchManager(IBranchDal branchDal)
        {
            _branchDal = branchDal;
        }

        public async Task<Branch> GetBranchWithIdAsync(int id)
        {
            return await _branchDal.GetAsync(x => x.Id == id);
        }

        public async Task<List<Branch>> GetAllBranchAsync()
        {
            return await _branchDal.GetAllAsync();
        }

        public async Task<bool> AddBranchAsync(Branch branch)
        {
            return await _branchDal.AddAsync(branch);
        }

        public async Task<bool> DeleteBranchAsync(Branch branch)
        {
            return await _branchDal.DeleteAsync(branch);
        }


        public async Task<bool> UpdateBranchAsync(Branch branch)
        {
            return await _branchDal.UpdateAsync(branch);

        }

        public async Task<List<Branch>> GetAllBranchAsync(string languageCode)
        {
            return await _branchDal.GetBranchAsync(languageCode);
        }
        public async Task<bool> BranchAnyAsync(Expression<Func<Branch, bool>> expression)
        {
            return await _branchDal.CheckBranch(expression);
        }
    }
}
