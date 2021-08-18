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
    public class EFMovieDetailDal : EFRepositoryBase<MovieDetail, AppDbContext>, IMovieDetailDal
    {
        public async Task<bool> CheckMovieDetail(Expression<Func<MovieDetail, bool>> expression)
        {
            await using var context = new AppDbContext();
            return await context.MovieDetails.AnyAsync(expression);
        }
        public async Task<MovieDetail> GetMovieDetailAsync(string languageCode,int id)
        {
            await using var context = new AppDbContext();
            return await context.MovieDetails.Include(x => x.Language)
                .Where(x => x.Language.Code == languageCode)
                .Include(x => x.Movie)
                .Where(x => x.MovieId == id)
                .FirstOrDefaultAsync();
        }
    }
}
