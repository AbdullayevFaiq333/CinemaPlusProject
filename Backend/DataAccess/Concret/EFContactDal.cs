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
        public EFContactDal(AppDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<bool> CheckContact(Expression<Func<Contact, bool>> expression) 
        {
            return await Context.Contacts.AnyAsync(expression);
        }
        public async Task<Contact> GetContactAsync(int id)
        {
            return await Context.Contacts
                .Include(x => x.Branch)
                .Where(x => x.BranchId == id)
                .FirstOrDefaultAsync();
        }
     

    }
}
