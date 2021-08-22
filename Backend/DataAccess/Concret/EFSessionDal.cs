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
    public class EFSessionDal : EFRepositoryBase<Session, AppDbContext>, ISessionDal
    {
        public async Task<bool> CheckSession(Expression<Func<Session, bool>> expression)
        {
            await using var context = new AppDbContext();
            return await context.Sessions.AnyAsync(expression);
        }
        public async Task<List<Session>> GetSessionAsync(int id)
        {
            await using var context = new AppDbContext();
            return await context.Sessions.Include(x => x.Tickets).Include(x=>x.Branch)
                .Include(x=>x.Hall).Include(x=>x.Movie).Where(x => x.MovieId == id)
                .ToListAsync();
        }
    }
}
