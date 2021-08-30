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
        public EFMovieDetailDal(AppDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<bool> CheckMovieDetail(Expression<Func<MovieDetail, bool>> expression)
        {
            return await Context.MovieDetails.AnyAsync(expression);
        }
        public async Task<MovieDetail> GetMovieDetailAsync(string languageCode,int id)
        {
            return await Context.MovieDetails.Include(x => x.Language)
                .Where(x => x.Language.Code == languageCode)
                .Include(x => x.Movie)
                .Where(x => x.MovieId == id)
                .FirstOrDefaultAsync();
        }
    }
}
