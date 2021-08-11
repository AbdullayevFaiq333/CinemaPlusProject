using Buisness.Abstract;
using DataAccess.Abstract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concret
{
    public class CinemaClubManager : ICinemaClubService
    {
        private readonly ICinemaClubDal _cinemaClubDal;

        public CinemaClubManager(ICinemaClubDal cinemaClubDal)
        {
            _cinemaClubDal = cinemaClubDal;
        }

        public async Task<CinemaClub> GetCinemaClubWithIdAsync(int id)
        {
            return await _cinemaClubDal.GetAsync(x => x.Id == id);
        }

        public async Task<List<CinemaClub>> GetAllCinemaClubAsync()
        {
            return await _cinemaClubDal.GetAllAsync();
        }

        public Task<bool> AddCinemaClubAsync(CinemaClub cinemaClub)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCinemaClubAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCinemaClubAsync(CinemaClub cinemaClub)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CinemaClub>> GetAllCinemaClubAsync(string languageCode)
        {
            return await _cinemaClubDal.GetCinemaClubAsync(languageCode);
        }
    }
}
