using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface IMovieDetailService
    {
        Task<MovieDetail> GetMovieDetailWithIdAsync(int movieId);
        Task<List<MovieDetail>> GetAllMovieDetailAsync();
        Task<MovieDetail> GetAllMovieDetailAsync(string languageCode,int id);

        Task<bool> AddMovieDetailAsync(MovieDetail movieDetail);
        Task<bool> UpdateMovieDetailAsync(MovieDetail movieDetail);
        Task<bool> DeleteMovieDetailAsync(MovieDetail movieDetail);
        Task<bool> MovieDetailAnyAsync(Expression<Func<MovieDetail, bool>> expression);

    }
}
