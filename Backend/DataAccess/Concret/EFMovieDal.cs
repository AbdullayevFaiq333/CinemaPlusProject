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
        public EFMovieDal(AppDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<bool> AddRangeAsync(params object[] entities)
        {
            await using var transaction = await Context.Database.BeginTransactionAsync();
            try
            {
                await Context.AddRangeAsync(entities);
                await Context.SaveChangesAsync();
                await transaction.CommitAsync();

                return true;
            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                throw;
            }

        }
        public async Task<bool> CheckMovie(Expression<Func<Movie, bool>> expression)
        {
            return await Context.Movies.AnyAsync(expression);
        } 

        public async Task<MovieDetail> GetMovieDetail(int? movieId)
        {
            return await Context.MovieDetails.SingleOrDefaultAsync(s => s.MovieId == movieId);
        }
        public async Task<List<Movie>> GetMovieAsync(string languageCode)
        {
            return await Context.Movies.Include(x => x.Language).Include(x=>x.MovieFormats).ThenInclude(x=>x.Format)
                .Include(x=>x.Sessions)
                .Where(x =>x.Language.Code == languageCode)
                .ToListAsync();
        }
    }
}
