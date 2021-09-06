using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface ITariffService
    {
        Task<Tariff> GetTariffWithIdAsync(int branchId);
        Task<List<Tariff>> GetAllTariffAsync();
        Task<Tariff> GetAllTariffAsync(int id);

        Task<bool> AddTariffAsync(Tariff tariff);
        Task<bool> UpdateTariffAsync(Tariff tariff);
        Task<bool> DeleteTariffAsync(int id);
        Task<bool> TariffAnyAsync(Expression<Func<Tariff, bool>> expression);

    }
}
