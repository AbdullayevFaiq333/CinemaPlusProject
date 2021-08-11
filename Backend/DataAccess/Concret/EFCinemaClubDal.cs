using Core.Repository.EFRepository;
using DataAccess.Abstract;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concret
{
    public class EFCinemaClubDal : EFRepositoryBase<CinemaClub, AppDbContext>, ICinemaClubDal
    {
        public async Task<List<CinemaClub>> GetCinemaClubAsync(string languageCode)
        {
            await using var context = new AppDbContext();
            return await context.CinemaClubs.Include(x => x.Language)
                .Where(x => x.IsDeleted == false && x.Language.Code == languageCode)
                .ToListAsync();
        }
    }
}
