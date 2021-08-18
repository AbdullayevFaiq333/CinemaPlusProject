using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface IAdvertisementService
    {
        Task<Advertisement> GetAdvertisementWithIdAsync(int id);
        Task<List<Advertisement>> GetAllAdvertisementAsync();
        Task<bool> AddAdvertisementAsync(Advertisement advertisement);
        Task<bool> UpdateAdvertisementAsync(Advertisement advertisement);
        Task<bool> DeleteAdvertisementAsync(int id);
        Task<bool> AdvertisementAnyAsync(Expression<Func<Advertisement, bool>> expression);

        
    }
}
