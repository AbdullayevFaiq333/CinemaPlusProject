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
    public class EFAboutUsBottomPartDal : EFRepositoryBase<AboutUsBottomPart, AppDbContext>, IAboutUsBottomPartDal
    {
        //burda niye her defe instance alinir dbContexden?        
        //Bu dbcontext dependency injectionan ctor-dan gelmelidir
        //onlari duzeldin chunki indi build kechmir heleki men commente atiram-ok
        //yadaki helelik parametrless ctor yaradiram

        public async Task<bool> CheckAboutUsBottomPart(Expression<Func<AboutUsBottomPart, bool>> expression)
        {
            await using var context = new AppDbContext();
            return await context.AboutUsBottomParts.AnyAsync(expression);
        }
        public async Task<List<AboutUsBottomPart>> GetAboutUsBottomPartAsync(string languageCode)
        {
            await using var context = new AppDbContext();
            return await context.AboutUsBottomParts.Include(x => x.Language)
                .Where(x => x.IsDeleted == false && x.Language.Code == languageCode)
                .ToListAsync();
        }
    }
}
