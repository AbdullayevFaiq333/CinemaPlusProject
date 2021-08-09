using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface IServiceService
    {
        Task<Service> GetServiceWithIdAsync(int id);
        Task<List<Service>> GetAllServiceAsync();
        Task<bool> AddServiceAsync(Service service);
        Task<bool> UpdateServiceAsync(Service service);
        Task<bool> DeleteServiceAsync(int id);
    }
}
