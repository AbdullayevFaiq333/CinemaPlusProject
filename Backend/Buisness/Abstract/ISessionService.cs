using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface ISessionService
    {
        Task<Session> GetSessionWithIdAsync(int id);
        Task<List<Session>> GetAllSessionAsync();
        Task<List<Session>> GetAllSessionAsync();

        Task<bool> AddSessionAsync(Session session);
        Task<bool> UpdateSessionAsync(Session session);
        Task<bool> DeleteSessionAsync(int id);
    }
}
