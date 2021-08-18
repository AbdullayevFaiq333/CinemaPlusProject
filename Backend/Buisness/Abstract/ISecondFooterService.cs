using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface ISecondFooterService
    {
        Task<SecondFooter> GetSecondFooterWithIdAsync(int id);
        Task<List<SecondFooter>> GetAllSecondFooterAsync();
        Task<List<SecondFooter>> GetAllSecondFooterAsync(string languageCode);

        Task<bool> AddSecondFooterAsync(SecondFooter secondFooter);
        Task<bool> UpdateSecondFooterAsync(SecondFooter secondFooter);
        Task<bool> DeleteSecondFooterAsync(int id);
        Task<bool> SecondFooterAnyAsync(Expression<Func<SecondFooter, bool>> expression);

    }
}
