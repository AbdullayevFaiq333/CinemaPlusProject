using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface ITariffService
    {
        Task<Tariff> GetTariffWithIdAsync(int id);
        Task<List<Tariff>> GetAllTariffAsync();
        Task<bool> AddTariffAsync(Tariff tariff);
        Task<bool> UpdateTariffAsync(Tariff tariff);
        Task<bool> DeleteTariffAsync(int id);
    }
}
