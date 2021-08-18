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
    public class MovieFormatManager : IMovieFormatService
    {
        private readonly IMovieFormatDal _movieFormatDal;

        public MovieFormatManager(IMovieFormatDal movieFormatDal)
        {
            _movieFormatDal = movieFormatDal;
        }
        public async Task<MovieFormat> GetMovieFormatWithIdAsync(int id)
        {
            return await _movieFormatDal.GetAsync(x => x.Id == id);
        }

        public async Task<List<MovieFormat>> GetAllMovieFormatAsync()
        {
            return await _movieFormatDal.GetAllAsync();
        }

        public Task<bool> AddMovieFormatAsync(MovieFormat movieFormat)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteMovieFormatAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateMovieFormatAsync(MovieFormat movieFormat)
        {
            throw new NotImplementedException();
        }
        public async Task<bool> MovieFormatAnyAsync(Expression<Func<MovieFormat, bool>> expression)
        {
            return await _movieFormatDal.CheckMovieFormat(expression);
        }
    }
}
