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
    public class RowManager : IRowService
    {
        private readonly IRowDal _rowDal;

        public RowManager(IRowDal rowDal)
        {
            _rowDal = rowDal;
        }
        public async Task<Row> GetRowWithIdAsync(int id)
        {
            return await _rowDal.GetAsync(x => x.Id == id);
        }
        public async Task<List<Row>> GetAllRowAsync()
        {
            return await _rowDal.GetAllAsync();
        }

        public Task<bool> AddRowAsync(Row row)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteRowAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateRowAsync(Row row)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Row>> GetAllRowAsync(int id)
        {
            return await _rowDal.GetRowAsync(id);
        }
        public async Task<bool> RowAnyAsync(Expression<Func<Row, bool>> expression)
        {
            return await _rowDal.CheckRow(expression);
        }

        
    }
}
