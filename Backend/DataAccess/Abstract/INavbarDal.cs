using Core.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface INavbarDal : IRepository<Navbar>
    {
        Task<List<Navbar>> GetNavbarAsync(string languageCode);
        Task<bool> CheckNavbar(Expression<Func<Navbar, bool>> expression);


    }
}
