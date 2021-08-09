using Buisness.Abstract;
using DataAccess.Abstract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concret
{
    public class HallManager : IHallService
    {
        private readonly IHallDal _hallDal;

        public HallManager(IHallDal hallDal)
        {
            _hallDal = hallDal;
        }
        public async Task<Hall> GetHallWithIdAsync(int id)
        {
            return await _hallDal.GetAsync(x => x.Id == id);
        }

        public async Task<List<Hall>> GetAllHallAsync()
        {
            return await _hallDal.GetAllAsync();
        }

        public Task<bool> AddHallAsync(Hall hall)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteHallAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateHallAsync(Hall hall)
        {
            throw new NotImplementedException();
        }
    }
}
