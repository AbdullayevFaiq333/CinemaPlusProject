using Buisness.Abstract;
using DataAccess.Abstract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concret
{
    public class TariffManager : ITariffService
    {
        private readonly ITariffDal _tariffDal;

        public TariffManager(ITariffDal tariffDal)
        {
            _tariffDal = tariffDal;
        }

        public async Task<Tariff> GetTariffWithIdAsync(int id)
        {
            return await _tariffDal.GetAsync(x => x.Id == id);
        }

        public async Task<List<Tariff>> GetAllTariffAsync()
        {
            return await _tariffDal.GetAllAsync();
        }

        public Task<bool> AddTariffAsync(Tariff tariff)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteTariffAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateTariffAsync(Tariff tariff)
        {
            throw new NotImplementedException();
        }

        public async Task<Tariff> GetAllTariffAsync(int id)
        {
            return await _tariffDal.GetTariffAsync( id);
        }
    }
}
