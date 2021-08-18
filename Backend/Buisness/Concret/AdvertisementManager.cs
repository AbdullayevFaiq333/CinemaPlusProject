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
    public class AdvertisementManager : IAdvertisementService
    {
        private readonly IAdvertisementDal _advertisementDal;

        public AdvertisementManager(IAdvertisementDal advertisementDal)
        {
            _advertisementDal = advertisementDal;
        }

        public async Task<Advertisement> GetAdvertisementWithIdAsync(int id)
        {
            return await _advertisementDal.GetAsync(x => x.Id == id);
        }

        public async Task<List<Advertisement>> GetAllAdvertisementAsync()
        {
            return await _advertisementDal.GetAllAsync();
        }

        public Task<bool> AddAdvertisementAsync(Advertisement advertisement)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAdvertisementAsync(int id)
        {
            throw new NotImplementedException();
        }


        public Task<bool> UpdateAdvertisementAsync(Advertisement advertisement)
        {
            throw new NotImplementedException();
        }
        public async Task<bool> AdvertisementAnyAsync(Expression<Func<Advertisement, bool>> expression)
        {
            return await _advertisementDal.CheckAdvertisement(expression);
        }
        
    }
}
