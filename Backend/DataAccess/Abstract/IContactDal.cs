using Core.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IContactDal : IRepository<Contact>
    {
        Task<Contact> GetContactAsync(int id);
        Task<bool> CheckContact(Expression<Func<Contact, bool>> expression);

    }
}
