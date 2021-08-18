using Core.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IMovieDetailDal : IRepository<MovieDetail>
    {
        Task<MovieDetail> GetMovieDetailAsync(string languageCode,int id);
        Task<bool> CheckMovieDetail(Expression<Func<MovieDetail, bool>> expression);


    }
}
