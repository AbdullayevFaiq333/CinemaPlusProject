using Core.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IAboutUsHeadPartDal:IRepository<AboutUsHeadPart>
    {
        Task<List<AboutUsHeadPart>> GetAboutUsHeadPartAsync(string languageCode);
        Task<bool> CheckAboutUsHeadPart(Expression<Func<AboutUsHeadPart, bool>> expression);
    }

}
