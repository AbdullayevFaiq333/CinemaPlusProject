using Buisness.Abstract;
using DataAccess.Abstract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concret
{
    public class DolbyAtmosManager : IDolbyAtmosService
    {
        private readonly IDolbyAtmosDal _dolbyAtmosDal;

        public DolbyAtmosManager(IDolbyAtmosDal dolbyAtmosDal)
        {
            _dolbyAtmosDal = dolbyAtmosDal;
        }
        public async Task<DolbyAtmos> GetDolbyAtmosWithIdAsync(int id)
        {
            return await _dolbyAtmosDal.GetAsync(x => x.Id == id);
        }

        public async Task<List<DolbyAtmos>> GetAllDolbyAtmosAsync() 
        {
            return await _dolbyAtmosDal.GetAllAsync();
        }


        public async Task<bool> AddDolbyAtmosAsync(DolbyAtmos dolbyAtmos)
        {
            return await _dolbyAtmosDal.AddAsync(dolbyAtmos);

        }

        public async Task<bool> DeleteDolbyAtmosAsync(DolbyAtmos dolbyAtmos)
        {
            return await _dolbyAtmosDal.DeleteAsync(dolbyAtmos);
        }

        public async Task<bool> UpdateDolbyAtmosAsync(DolbyAtmos dolbyAtmos)
        {
            return await _dolbyAtmosDal.UpdateAsync(dolbyAtmos);

        }

        public async Task<List<DolbyAtmos>> GetAllDolbyAtmosAsync(string languageCode)
        {
            return await _dolbyAtmosDal.GetDolbyAtmosAsync(languageCode);
        }
        public async Task<bool> DolbyAtmosAnyAsync(Expression<Func<DolbyAtmos, bool>> expression)
        {
            return await _dolbyAtmosDal.CheckDolbyAtmos(expression);
        }
       
    }
}
