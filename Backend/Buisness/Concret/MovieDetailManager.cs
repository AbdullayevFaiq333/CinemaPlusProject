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
    public class MovieDetailManager : IMovieDetailService
    {
        private readonly IMovieDetailDal _movieDetailDal;

        public MovieDetailManager(IMovieDetailDal movieDetailDal)
        {
            _movieDetailDal = movieDetailDal;
        }
        public async Task<MovieDetail> GetMovieDetailWithIdAsync(int movieId)
        {
            return await _movieDetailDal.GetAsync(x => x.MovieId == movieId);
        }

        public async Task<List<MovieDetail>> GetAllMovieDetailAsync()
        {
            return await _movieDetailDal.GetAllAsync();
        }

        public async Task<bool> AddMovieDetailAsync(MovieDetail movieDetail)
        {
            await _movieDetailDal.AddAsync(movieDetail);
            return true;
        }

        public async Task<bool> DeleteMovieDetailAsync(MovieDetail movieDetail)
        {
            return await _movieDetailDal.DeleteAsync(movieDetail);
        }


        public Task<bool> UpdateMovieDetailAsync(MovieDetail movieDetail)
        {
            throw new NotImplementedException();
        }

        public async Task<MovieDetail> GetAllMovieDetailAsync(string languageCode,int id)
        {
            return await _movieDetailDal.GetMovieDetailAsync(id);

        }
        public async Task<bool> MovieDetailAnyAsync(Expression<Func<MovieDetail, bool>> expression)
        {
            return await _movieDetailDal.CheckMovieDetail(expression);
        }
    }
}
