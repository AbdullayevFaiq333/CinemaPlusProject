﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface IRowService
    {
        Task<Row> GetRowWithIdAsync(int id);
        Task<List<Row>> GetAllRowAsync();
        Task<bool> AddRowAsync(Row row);
        Task<bool> UpdateRowAsync(Row row);
        Task<bool> DeleteRowAsync(int id);
    }
}
