using Buisness.Abstract;
using DataAccess.Abstract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concret
{
    public class FormatManager : IFormatService
    {
        private readonly IFormatDal _formatDal;

        public FormatManager(IFormatDal formatDal)
        {
            _formatDal = formatDal;
        }
        public async Task<Format> GetFormatWithIdAsync(int id)
        {
            return await _formatDal.GetAsync(x => x.Id == id);
        }

        public async Task<List<Format>> GetAllFormatAsync()
        {
            return await _formatDal.GetAllAsync();
        }

        public Task<bool> AddFormatAsync(Format format)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteFormatAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateFormatAsync(Format format)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Format>> GetAllFormatAsync(string languageCode)
        {
            return await _formatDal.GetFormatAsync(languageCode);

        }
    }
}
