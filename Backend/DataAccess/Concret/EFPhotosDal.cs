using Core.Repository.EFRepository;
using DataAccess.Abstract;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concret
{
    public class EFPhotosDal : EFRepositoryBase<Photos, AppDbContext>, IPhotosDal
    {
        public async Task<bool> CheckPhotos(Expression<Func<Photos, bool>> expression)
        {
            await using var context = new AppDbContext();
            return await context.Photos.AnyAsync(expression);
        }
    }
}
