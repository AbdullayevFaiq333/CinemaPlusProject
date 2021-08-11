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
    public class EFPlatiniumDal : EFRepositoryBase<Platinium, AppDbContext>, IPlatiniumDal
    {
        public async Task<List<Platinium>> GetPlatiniumAsync(string languageCode)
        {
            await using var context = new AppDbContext();
            return await context.Platiniums.Include(x => x.Language)
                .Where(x => x.IsDeleted == false && x.Language.Code == languageCode)
                .ToListAsync();
        }
    }
}
