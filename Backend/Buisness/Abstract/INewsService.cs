using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface INewsService
    {
        Task<News> GetNewsWithIdAsync(int id);
        Task<List<News>> GetAllNewsAsync();
        Task<List<News>> GetAllNewsAsync(string languageCode);

        Task<bool> AddNewsAsync(News news);
        Task<bool> UpdateNewsAsync(News news);
        Task<bool> DeleteNewsAsync(int id);
        Task<bool> NewsAnyAsync(Expression<Func<News, bool>> expression);

    }
}
