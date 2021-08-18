using Buisness.Abstract;
using DataAccess.Abstract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concret
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }
        public async Task<Contact> GetContactWithIdAsync(int id)
        {
            return await _contactDal.GetAsync(x => x.Id == id);
        }

        public async Task<List<Contact>> GetAllContactAsync()
        {
            return await _contactDal.GetAllAsync();
        }


        public Task<bool> AddContactAsync(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteContactAsync(int id)
        {
            throw new NotImplementedException();
        }


        public Task<bool> UpdateContactAsync(Contact contact)
        {
            throw new NotImplementedException();
        }

        public async Task<Contact> GetAllContactAsync(int id)
        {
            return await _contactDal.GetContactAsync(id);
        }
    }
}
