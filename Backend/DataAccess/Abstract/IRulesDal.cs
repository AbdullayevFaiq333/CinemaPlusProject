using Core.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IRulesDal : IRepository<Rules>
    {
        Task<List<Rules>> GetRulesAsync(string languageCode);
        Task<bool> CheckRules(Expression<Func<Rules, bool>> expression);


    }
}
