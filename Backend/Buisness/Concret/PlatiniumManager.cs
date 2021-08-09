using Buisness.Abstract;
using DataAccess.Abstract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concret
{
    public class PlatiniumManager : IPlatiniumService
    {
        private readonly IPlatiniumDal _platiniumDal;

        public PlatiniumManager(IPlatiniumDal platiniumDal)
        {
            _platiniumDal = platiniumDal;
        }
        public async Task<Platinium> GetPlatiniumWithIdAsync(int id)
        {
            return await _platiniumDal.GetAsync(x => x.Id == id);
        }

        public async Task<List<Platinium>> GetAllPlatiniumAsync()
        {
            return await _platiniumDal.GetAllAsync();
        }

        public Task<bool> AddPlatiniumAsync(Platinium platinium)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePlatiniumAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePlatiniumAsync(Platinium platinium)
        {
            throw new NotImplementedException();
        }
    }
}
