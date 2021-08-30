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
    public class EFBranchDal : EFRepositoryBase<Branch, AppDbContext>, IBranchDal
    {
        public EFBranchDal(AppDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<bool> AddRangeAsync(params object[] entities)
        {
           
            await using var transaction = await Context.Database.BeginTransactionAsync();
            try
            {
                await Context.AddRangeAsync(entities);
                await Context.SaveChangesAsync();
                await transaction.CommitAsync();

                return true;
            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                throw;
            }

        }

        public async Task<bool> CheckBranch(Expression<Func<Branch, bool>> expression)
        {
            
            return await Context.Branches.AnyAsync(expression);
        }
        public async Task<List<Branch>> GetBranchAsync(string languageCode)
        {
            
            return await Context.Branches.Include(x => x.Language)
                .Include(x => x.Photos).Include(x => x.Tariff).Include(x => x.Contact)
                .Where(x => x.Language.Code == languageCode)
                .ToListAsync();
        }

        public async Task<Branch> GetBranchWithInclude(int id)
        {
            
            return await Context.Branches.Include(x => x.Tariff).Include(x => x.Contact)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

    }
}
