using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface INewsService
    {
        Task<News> GetNewsWithIdAsync(int id);
        Task<List<News>> GetAllNewsAsync();
        Task<bool> AddNewsAsync(News news);
        Task<bool> UpdateNewsAsync(News news);
        Task<bool> DeleteNewsAsync(int id);
    }
}
