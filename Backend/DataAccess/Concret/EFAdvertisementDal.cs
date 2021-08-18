using Core.Repository.EFRepository;
using DataAccess.Abstract;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concret
{
    public class EFAdvertisementDal : EFRepositoryBase<Advertisement, AppDbContext>, IAdvertisementDal
    {

        public async Task<bool> CheckAdvertisement(Expression<Func<Advertisement, bool>> expression)
        {
            await using var context = new AppDbContext();
            return await context.Advertisements.AnyAsync(expression);
        }

    }
}
