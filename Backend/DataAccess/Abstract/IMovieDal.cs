using Core.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IMovieDal : IRepository<Movie>
    {
        Task<List<Movie>> GetMovieAsync(string languageCode);
        Task<bool> CheckMovie(Expression<Func<Movie, bool>> expression);
        Task<MovieDetail> GetMovieDetail(int? movieId);
        Task<Movie> GetMovieWithIdAsync(int id); 




    }
}
