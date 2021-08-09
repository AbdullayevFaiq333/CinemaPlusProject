using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface ISecondNavbarService
    {
        Task<SecondNavbar> GetSecondNavbarWithIdAsync(int id);
        Task<List<SecondNavbar>> GetAllSecondNavbarAsync();
        Task<bool> AddSecondNavbarAsync(SecondNavbar secondNavbar);
        Task<bool> UpdateSecondNavbarAsync(SecondNavbar secondNavbar);
        Task<bool> DeleteSecondNavbarAsync(int id);
    }
}
