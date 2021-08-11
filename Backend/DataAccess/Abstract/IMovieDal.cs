using Core.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IMovieDal : IRepository<Movie>
    {
        Task<List<Movie>> GetMovieAsync(string languageCode);

    }
}
