using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface IFooterService
    {
        Task<Footer> GetFooterWithIdAsync(int id);
        Task<List<Footer>> GetAllFooterAsync();
        Task<List<Footer>> GetAllFooterAsync(string languageCode);

        Task<bool> AddFooterAsync(Footer footer);
        Task<bool> UpdateFooterAsync(Footer footer);
        Task<bool> DeleteFooterAsync(int id);
        Task<bool> FooterAnyAsync(Expression<Func<Footer, bool>> expression);

    }
}
