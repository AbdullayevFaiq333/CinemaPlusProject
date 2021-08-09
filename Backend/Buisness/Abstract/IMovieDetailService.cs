using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface IMovieDetailService
    {
        Task<MovieDetail> GetMovieDetailWithIdAsync(int id);
        Task<List<MovieDetail>> GetAllMovieDetailAsync();
        Task<bool> AddMovieDetailAsync(MovieDetail movieDetail);
        Task<bool> UpdateMovieDetailAsync(MovieDetail movieDetail);
        Task<bool> DeleteMovieDetailAsync(int id);
    }
}
