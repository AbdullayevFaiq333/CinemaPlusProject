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
    public class PhotosManager : IPhotosService
    {
        private readonly IPhotosDal _photosDal;

        public PhotosManager(IPhotosDal photosDal)
        {
            _photosDal = photosDal;
        }
        public async Task<Photos> GetPhotosWithIdAsync(int branchId)
        {
            return await _photosDal.CheckPhotosId(branchId);
        }

        public async Task<List<Photos>> GetAllPhotosAsync()
        {
            return await _photosDal.GetAllAsync();
        }

        public Task<bool> AddPhotosAsync(Photos photos)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePhotosAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePhotosAsync(Photos photos)
        {
            throw new NotImplementedException();
        }
        public async Task<bool> PhotosAnyAsync(Expression<Func<Photos, bool>> expression)
        {
            return await _photosDal.CheckPhotos(expression);
        }
    }
}
