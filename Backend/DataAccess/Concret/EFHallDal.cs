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
    public class EFHallDal : EFRepositoryBase<Hall, AppDbContext>, IHallDal
    {
        public EFHallDal(AppDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<bool> CheckHall(Expression<Func<Hall, bool>> expression)
        {
            
            return await Context.Halls.AnyAsync(expression);
        }
        public async Task<Hall> GetHallAsync(string languageCode,int id)
        {
            return await Context.Halls.Include(x => x.Language).Include(x=>x.Rows)
                .Where(x => x.Language.Code == languageCode).Include(x=>x.Sessions).Where(x=>x.Sessions.Any(x => x.HallId==id))
                .FirstOrDefaultAsync();
        }
    }
}
