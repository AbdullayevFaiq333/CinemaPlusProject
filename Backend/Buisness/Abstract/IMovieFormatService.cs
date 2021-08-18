using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface IMovieFormatService
    {
        Task<MovieFormat> GetMovieFormatWithIdAsync(int id);
        Task<List<MovieFormat>> GetAllMovieFormatAsync();
        Task<bool> AddMovieFormatAsync(MovieFormat movieFormat);
        Task<bool> UpdateMovieFormatAsync(MovieFormat movieFormat);
        Task<bool> DeleteMovieFormatAsync(int id);
        Task<bool> MovieFormatAnyAsync(Expression<Func<MovieFormat, bool>> expression);

    }
}
