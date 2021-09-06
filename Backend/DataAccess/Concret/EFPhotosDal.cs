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
        public EFPhotosDal(AppDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<bool> CheckPhotos(Expression<Func<Photos, bool>> expression)
        {
            return await Context.Photos.AnyAsync(expression);
        }
        public async Task<Photos> CheckPhotosId(int? branchId) 
        {
            return await Context.Photos.Include(i => i.Branches)
                       .SingleOrDefaultAsync(s => s.Branches.Any(a => a.Id == branchId));

            
        }
    }
}
