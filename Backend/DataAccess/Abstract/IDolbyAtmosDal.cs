using Core.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IDolbyAtmosDal : IRepository<DolbyAtmos>
    {
        Task<List<DolbyAtmos>> GetDolbyAtmosAsync(string languageCode);
        Task<bool> CheckDolbyAtmos(Expression<Func<DolbyAtmos, bool>> expression);

    }
}
