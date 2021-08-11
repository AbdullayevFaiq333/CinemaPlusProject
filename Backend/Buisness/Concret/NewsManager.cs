using Buisness.Abstract;
using DataAccess.Abstract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concret
{
    public class NewsManager : INewsService
    {
        private readonly INewsDal _newsDal;

        public NewsManager(INewsDal newsDal)
        {
            _newsDal = newsDal;
        }
        public async Task<News> GetNewsWithIdAsync(int id)
        {
            return await _newsDal.GetAsync(x => x.Id == id);
        }

        public async Task<List<News>> GetAllNewsAsync()
        {
            return await _newsDal.GetAllAsync();
        }

        public Task<bool> AddNewsAsync(News news)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteNewsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateNewsAsync(News news)
        {
            throw new NotImplementedException();
        }

        public async Task<List<News>> GetAllNewsAsync(string languageCode)
        {
            return await _newsDal.GetNewsAsync(languageCode);

        }
    }
}
