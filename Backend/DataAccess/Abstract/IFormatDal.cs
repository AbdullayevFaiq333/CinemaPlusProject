using Core.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IFormatDal : IRepository<Format>
    {
        Task<List<Format>> GetFormatAsync(string languageCode);
        Task<bool> CheckFormat(Expression<Func<Format, bool>> expression);


    }
}
