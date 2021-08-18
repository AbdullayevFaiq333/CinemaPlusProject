using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface IContactService
    {
        Task<Contact> GetContactWithIdAsync(int id);
        Task<List<Contact>> GetAllContactAsync();
        Task<Contact> GetAllContactAsync(int id);
        Task<bool> AddContactAsync(Contact contact);
        Task<bool> UpdateContactAsync(Contact contact);
        Task<bool> DeleteContactAsync(int id);
    }
}
