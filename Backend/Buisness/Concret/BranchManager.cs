using Buisness.Abstract;
using DataAccess.Abstract;
using Entities.Models;
using System;
using System.Collections.Generic;
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

        public Task<bool> AddBranchAsync(Branch branch)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteBranchAsync(int id)
        {
            throw new NotImplementedException();
        }


        public Task<bool> UpdateBranchAsync(Branch branch)
        {
            throw new NotImplementedException();
        }
    }
}
