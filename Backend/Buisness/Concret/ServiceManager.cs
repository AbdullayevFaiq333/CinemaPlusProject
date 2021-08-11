using Buisness.Abstract;
using DataAccess.Abstract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concret
{
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }
        public async Task<Service> GetServiceWithIdAsync(int id)
        {
            return await _serviceDal.GetAsync(x => x.Id == id);
        }

        public async Task<List<Service>> GetAllServiceAsync()
        {
            return await _serviceDal.GetAllAsync();
        }

        public Task<bool> AddServiceAsync(Service service)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteServiceAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateServiceAsync(Service service)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Service>> GetAllServiceAsync(string languageCode)
        {
            return await _serviceDal.GetServiceAsync(languageCode);

        }
    }
}
