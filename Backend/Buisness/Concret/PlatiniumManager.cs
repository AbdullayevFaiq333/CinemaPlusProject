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

        public async Task<bool> AddPlatiniumAsync(Platinium platinium)
        {
            return await _platiniumDal.AddAsync(platinium);
        }

        public Task<bool> DeletePlatiniumAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePlatiniumAsync(Platinium platinium)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Platinium>> GetAllPlatiniumAsync(string languageCode)
        {
            return await _platiniumDal.GetPlatiniumAsync(languageCode);

        }

        public Task AddPlatiniumAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> PlatinumAnyAsync(Expression<Func<Platinium, bool>> expression)
        {
            return await _platiniumDal.CheckPlatinumItem(expression);
        }
    }
}
