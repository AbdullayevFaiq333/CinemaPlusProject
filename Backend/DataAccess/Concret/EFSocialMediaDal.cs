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
    public class EFSocialMediaDal : EFRepositoryBase<SocialMedia, AppDbContext>, ISocialMediaDal
    {
        public async Task<bool> CheckSocialMedia(Expression<Func<SocialMedia, bool>> expression)
        {
            await using var context = new AppDbContext();
            return await context.SocialMedias.AnyAsync(expression);
        }
    }
}
