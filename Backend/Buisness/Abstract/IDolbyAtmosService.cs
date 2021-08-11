using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface IDolbyAtmosService
    {
        Task<DolbyAtmos> GetDolbyAtmosWithIdAsync(int id);
        Task<List<DolbyAtmos>> GetAllDolbyAtmosAsync();
        Task<List<DolbyAtmos>> GetAllDolbyAtmosAsync(string languageCode);
        Task<bool> AddDolbyAtmosAsync(DolbyAtmos dolbyAtmos);
        Task<bool> UpdateDolbyAtmosAsync(DolbyAtmos dolbyAtmos);
        Task<bool> DeleteDolbyAtmosAsync(int id);
    }
}
