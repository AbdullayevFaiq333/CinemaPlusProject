using Core.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ILanguageDal : IRepository<Language>
    {
        Task<bool> CheckLanguage(Expression<Func<Language, bool>> expression);

    }
}
