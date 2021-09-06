using Entities.Models;
using Entity.Params;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface IMovieService
    {
        Task<Movie> GetMovieWithIdAsync(int id);
        Task<List<Movie>> GetAllMovieAsync();  
        Task<List<Movie>> GetAllMovieAsync(string languageCode);

        Task<bool> AddMovieAsync(MovieParams movieParams);
        Task<bool> UpdateMovieAsync(MovieParams movieParams, string oldPhoto); 
        Task<bool> DeleteMovieAsync(int? id);
        Task<bool> MovieAnyAsync(Expression<Func<Movie, bool>> expression);
        Task<MovieDetail> GetMovieDetail(int? movieId);





    }
}
