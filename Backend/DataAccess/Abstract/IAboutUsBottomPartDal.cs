using Core.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IAboutUsBottomPartDal:IRepository<AboutUsBottomPart>
    {
        Task<List<AboutUsBottomPart>> GetAboutUsBottomPartAsync(string languageCode);
        Task<bool> CheckAboutUsBottomPart(Expression<Func<AboutUsBottomPart, bool>> expression);

    }
}
