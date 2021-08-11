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
    public class EFHallDal : EFRepositoryBase<Hall, AppDbContext>, IHallDal
    {
        public async Task<List<Hall>> GetHallAsync(string languageCode)
        {
            await using var context = new AppDbContext();
            return await context.Halls.Include(x => x.Language).Include(x=>x.Rows)
                .Where(x => x.Language.Code == languageCode)
                .ToListAsync();
        }
    }
}
