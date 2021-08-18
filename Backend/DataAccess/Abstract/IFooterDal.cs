using Core.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IFooterDal : IRepository<Footer>
    {
        Task<List<Footer>> GetFooterAsync(string languageCode);
        Task<bool> CheckFooter(Expression<Func<Footer, bool>> expression);


    }
}
