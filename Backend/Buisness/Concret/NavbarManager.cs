using Buisness.Abstract;
using DataAccess.Abstract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concret
{
    public class NavbarManager : INavbarService
    {
        private readonly INavbarDal _navbarDal;

        public NavbarManager(INavbarDal navbarDal)
        {
            _navbarDal = navbarDal;
        }
        public async Task<Navbar> GetNavbarWithIdAsync(int id)
        {
            return await _navbarDal.GetAsync(x => x.Id == id);
        }

        public async Task<List<Navbar>> GetAllNavbarAsync()
        {
            return await _navbarDal.GetAllAsync();
        }

        public Task<bool> AddNavbarAsync(Navbar navbar)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteNavbarAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateNavbarAsync(Navbar navbar)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Navbar>> GetAllNavbarAsync(string languageCode)
        {
            return await _navbarDal.GetNavbarAsync(languageCode);

        }
        public async Task<bool> NavbarAnyAsync(Expression<Func<Navbar, bool>> expression)
        {
            return await _navbarDal.CheckNavbar(expression);
        }
    }
}
