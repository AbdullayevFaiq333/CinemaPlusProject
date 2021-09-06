using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface IPhotosService
    {
        Task<Photos> GetPhotosWithIdAsync(int branchId);
        Task<List<Photos>> GetAllPhotosAsync();
        Task<bool> AddPhotosAsync(Photos photos);
        Task<bool> UpdatePhotosAsync(Photos photos);
        Task<bool> DeletePhotosAsync(int id);
        Task<bool> PhotosAnyAsync(Expression<Func<Photos, bool>> expression);

    }
}
