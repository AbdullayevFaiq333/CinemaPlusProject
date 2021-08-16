using Core.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IPlatiniumDal : IRepository<Platinium>
    {
        Task<List<Platinium>> GetPlatiniumAsync(string languageCode);

        Task<bool> CheckPlatinumItem(Expression<Func<Platinium, bool>> expression);

    }
}
