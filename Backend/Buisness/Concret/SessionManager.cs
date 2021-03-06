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
    public class SessionManager : ISessionService
    {
        private readonly ISessionDal _sessionDal;

        public SessionManager(ISessionDal sessionDal)
        {
            _sessionDal = sessionDal;
        }
        public async Task<Session> GetSessionWithIdAsync(int id)
        {
            return await _sessionDal.GetAsync(x => x.Id == id);
        }

        public async Task<List<Session>> GetAllSessionAsync()
        {
            return await _sessionDal.GetAllAsync();
        }

        public Task<bool> AddSessionAsync(Session session)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSessionAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateSessionAsync(Session session)
        {
            throw new NotImplementedException();
        }
        public async Task<List<Session>> GetAllSessionAsync(int id)
        {
            return await _sessionDal.GetSessionAsync(id);
        }

        public async Task<bool> SessionAnyAsync(Expression<Func<Session, bool>> expression)
        {
            return await _sessionDal.CheckSession(expression);
        }

        
    }
}
