using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface INavbarService
    {
        Task<Navbar> GetNavbarWithIdAsync(int id);
        Task<List<Navbar>> GetAllNavbarAsync();
        Task<List<Navbar>> GetAllNavbarAsync(string languageCode);

        Task<bool> AddNavbarAsync(Navbar navbar);
        Task<bool> UpdateNavbarAsync(Navbar navbar);
        Task<bool> DeleteNavbarAsync(int id);
        Task<bool> NavbarAnyAsync(Expression<Func<Navbar, bool>> expression);

    }
}
