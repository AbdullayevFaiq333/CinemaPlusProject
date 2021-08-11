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
    public class EFDolbyAtmosDal : EFRepositoryBase<DolbyAtmos, AppDbContext>, IDolbyAtmosDal
    {
        public async Task<List<DolbyAtmos>> GetDolbyAtmosAsync(string languageCode)
        {
            await using var context = new AppDbContext();
            return await context.DolbyAtmos.Include(x => x.Language)
                .Where(x => x.Language.Code == languageCode)
                .ToListAsync();
        }
    }
}
