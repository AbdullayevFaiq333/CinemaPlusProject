using Core.Repository.EFRepository;
using DataAccess.Abstract;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concret
{
    public class EFContactDal : EFRepositoryBase<Contact, AppDbContext>, IContactDal
    {
        public async Task<bool> CheckContact(Expression<Func<Contact, bool>> expression)
        {
            await using var context = new AppDbContext();
            return await context.Contacts.AnyAsync(expression);
        }
        public async Task<Contact> GetContactAsync(int id)
        {
            await using var context = new AppDbContext();
            return await context.Contacts
                .Include(x => x.Branch)
                .Where(x => x.BranchId == id)
                .FirstOrDefaultAsync();
        }

        
    }
}
