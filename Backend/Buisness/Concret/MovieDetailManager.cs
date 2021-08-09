using Buisness.Abstract;
using DataAccess.Abstract;
using Entities.Models;
using System;
using System.Collections.Generic;
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
        public async Task<MovieDetail> GetMovieDetailWithIdAsync(int id)
        {
            return await _movieDetailDal.GetAsync(x => x.Id == id);
        }

        public async Task<List<MovieDetail>> GetAllMovieDetailAsync()
        {
            return await _movieDetailDal.GetAllAsync();
        }

        public Task<bool> AddMovieDetailAsync(MovieDetail movieDetail)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteMovieDetailAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateMovieDetailAsync(MovieDetail movieDetail)
        {
            throw new NotImplementedException();
        }
    }
}
