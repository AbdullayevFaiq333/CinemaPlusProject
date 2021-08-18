using Core.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IAdvertisementDal:IRepository<Advertisement>
    {
        
        Task<bool> CheckAdvertisement(Expression<Func<Advertisement, bool>> expression);

    }
}
