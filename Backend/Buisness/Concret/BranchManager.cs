using Buisness.Abstract;
using DataAccess.Abstract;
using Entities.Models;
using Microsoft.Extensions.Hosting;
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
        private readonly IHostEnvironment _environment;


        public BranchManager(IBranchDal branchDal, IHostEnvironment environment)
        {
            _branchDal = branchDal;
            _environment = environment;
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
        public async Task<Branch> GetBranchAsync(int? id)
        {
            return await _branchDal.GetBranchWithInclude(id.Value);
        }

        public async Task<bool> AddRangeAsync(params object[] entities)
        {
             return await _branchDal.AddRangeAsync(entities);
        }
    }
}
