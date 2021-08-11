using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface IFormatService
    {
        Task<Format> GetFormatWithIdAsync(int id);
        Task<List<Format>> GetAllFormatAsync();
        Task<List<Format>> GetAllFormatAsync(string languageCode);

        Task<bool> AddFormatAsync(Format format);
        Task<bool> UpdateFormatAsync(Format format);
        Task<bool> DeleteFormatAsync(int id);
    }
}
