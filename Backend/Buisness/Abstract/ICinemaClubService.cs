using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface ICinemaClubService
    {
        Task<CinemaClub> GetCinemaClubWithIdAsync(int id);
        Task<List<CinemaClub>> GetAllCinemaClubAsync();
        Task<List<CinemaClub>> GetAllCinemaClubAsync(string languageCode);
        Task<bool> AddCinemaClubAsync(CinemaClub cinemaClub);
        Task<bool> UpdateCinemaClubAsync(CinemaClub cinemaClub);
        Task<bool> DeleteCinemaClubAsync(int id);
        Task<bool> CinemaClubAnyAsync(Expression<Func<CinemaClub, bool>> expression);

    }
}
