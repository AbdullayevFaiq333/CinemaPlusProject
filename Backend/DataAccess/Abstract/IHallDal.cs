using Core.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IHallDal:IRepository<Hall>
    {
        Task<Hall> GetHallAsync(string languageCode,int id);
        Task<bool> CheckHall(Expression<Func<Hall, bool>> expression);

    }
}
