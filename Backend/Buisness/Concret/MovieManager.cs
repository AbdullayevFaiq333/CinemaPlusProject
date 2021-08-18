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
    public class MovieManager : IMovieService
    {
        private readonly IMovieDal _movieDal;

        public MovieManager(IMovieDal movieDal)
        {
            _movieDal = movieDal;
        }
        public async Task<Movie> GetMovieWithIdAsync(int id)
        {
            return await _movieDal.GetAsync(x => x.Id == id);
        }

        public async Task<List<Movie>> GetAllMovieAsync()
        {
            return await _movieDal.GetAllAsync();
        }

        public Task<bool> AddMovieAsync(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteMovieAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateMovieAsync(Movie movie)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Movie>> GetAllMovieAsync(string languageCode)
        {
            return await _movieDal.GetMovieAsync(languageCode);

        }
        public async Task<bool> MovieAnyAsync(Expression<Func<Movie, bool>> expression)
        {
            return await _movieDal.CheckMovie(expression);
        }
    }
}
