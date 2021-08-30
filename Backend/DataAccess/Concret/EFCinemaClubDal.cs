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
    public class EFCinemaClubDal : EFRepositoryBase<CinemaClub, AppDbContext>, ICinemaClubDal
    {
        public EFCinemaClubDal(AppDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<bool> CheckCinemaClub(Expression<Func<CinemaClub, bool>> expression)
        {
            return await Context.CinemaClubs.AnyAsync(expression);
        }
        public async Task<List<CinemaClub>> GetCinemaClubAsync(string languageCode)
        {
            return await Context.CinemaClubs.Include(x => x.Language)
                .Where(x => x.IsDeleted == false && x.Language.Code == languageCode)
                .ToListAsync();
        }
    }
}
