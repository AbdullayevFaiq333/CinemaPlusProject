using Core.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ISessionDal : IRepository<Session>
    {
        Task<List<Session>> GetSessionAsync();
        Task<bool> CheckSession(Expression<Func<Session, bool>> expression);

    }
}
