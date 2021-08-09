using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface ICinemaClubService
    {
        Task<CinemaClub> GetCinemaClubWithIdAsync(int id);
        Task<List<CinemaClub>> GetAllCinemaClubAsync();
        Task<bool> AddCinemaClubAsync(CinemaClub cinemaClub);
        Task<bool> UpdateCinemaClubAsync(CinemaClub cinemaClub);
        Task<bool> DeleteCinemaClubAsync(int id);
    }
}
