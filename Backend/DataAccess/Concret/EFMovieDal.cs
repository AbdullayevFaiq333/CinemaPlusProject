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
    public class EFMovieDal : EFRepositoryBase<Movie, AppDbContext>, IMovieDal
    {
        public async Task<bool> CheckMovie(Expression<Func<Movie, bool>> expression)
        {
            await using var context = new AppDbContext();
            return await context.Movies.AnyAsync(expression);
        } 

        public async Task<MovieDetail> GetMovieDetail(int? movieId)
        {
            await using var context = new AppDbContext();
            return await context.MovieDetails.SingleOrDefaultAsync(s => s.MovieId == movieId);
        }
        public async Task<List<Movie>> GetMovieAsync(string languageCode)
        {
            await using var context = new AppDbContext();
            return await context.Movies.Include(x => x.Language).Include(x=>x.MovieFormats).ThenInclude(x=>x.Format)
                .Include(x=>x.Sessions)
                .Where(x =>x.Language.Code == languageCode)
                .ToListAsync();
        }
    }
}
