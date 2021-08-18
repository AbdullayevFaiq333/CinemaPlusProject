using Core.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IServiceDal : IRepository<Service>
    {
        Task<List<Service>> GetServiceAsync(string languageCode);
        Task<bool> CheckService(Expression<Func<Service, bool>> expression);


    }
}
