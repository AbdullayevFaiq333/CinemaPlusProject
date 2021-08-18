using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface IRowService
    {
        Task<Row> GetRowWithIdAsync(int id);
        Task<List<Row>> GetAllRowAsync();
        Task<List<Row>> GetAllRowsAsync();

        Task<bool> AddRowAsync(Row row);
        Task<bool> UpdateRowAsync(Row row);
        Task<bool> DeleteRowAsync(int id);
        Task<bool> RowAnyAsync(Expression<Func<Row, bool>> expression);

    }
}
