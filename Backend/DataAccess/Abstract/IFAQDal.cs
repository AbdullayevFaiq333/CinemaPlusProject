using Core.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IFAQDal : IRepository<FAQ>
    {
        Task<List<FAQ>> GetFAQAsync(string languageCode);
        Task<bool> CheckFAQ(Expression<Func<FAQ, bool>> expression);

    }
}
