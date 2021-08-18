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
        Task<List<Hall>> GetHallAsync(string languageCode);
        Task<bool> CheckHall(Expression<Func<Hall, bool>> expression);

    }
}
