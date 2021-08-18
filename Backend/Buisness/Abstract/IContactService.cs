using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface IContactService
    {
        Task<Contact> GetContactWithIdAsync(int id);
        Task<List<Contact>> GetAllContactAsync();
        Task<bool> AddContactAsync(Contact contact);
        Task<bool> UpdateContactAsync(Contact contact);
        Task<bool> DeleteContactAsync(int id);
        Task<bool> ContactAnyAsync(Expression<Func<Contact, bool>> expression);

    }
}
