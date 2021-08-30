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
    public class EFMovieFormatDal : EFRepositoryBase<MovieFormat, AppDbContext>, IMovieFormatDal
    {
        public EFMovieFormatDal(AppDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<bool> CheckMovieFormat(Expression<Func<MovieFormat, bool>> expression)
        {
            return await Context.MovieFormats.AnyAsync(expression);
        }
    }
}
