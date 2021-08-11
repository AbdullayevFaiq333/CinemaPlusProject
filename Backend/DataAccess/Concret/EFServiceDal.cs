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
    public class EFServiceDal : EFRepositoryBase<Service, AppDbContext>, IServiceDal
    {
        public async Task<List<Service>> GetServiceAsync(string languageCode)
        {
            await using var context = new AppDbContext();
            return await context.Services.Include(x => x.Language)
                .Where(x => x.Language.Code == languageCode)
                .ToListAsync();
        }
    }
}
