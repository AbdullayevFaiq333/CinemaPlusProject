using Core.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICinemaClubDal : IRepository<CinemaClub>
    {
        Task<List<CinemaClub>> GetCinemaClubAsync(string languageCode);
        Task<bool> CheckCinemaClub(Expression<Func<CinemaClub, bool>> expression);

    }
}
