using Core.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBranchDal : IRepository<Branch>
    { 
        Task<List<Branch>> GetBranchAsync(string languageCode);
        Task<bool> CheckBranch(Expression<Func<Branch, bool>> expression);
        Task<Branch> GetBranchWithInclude(int id);

        Task<Contact> GetContact(int? id);
        Task<Tariff> GetTariff(int? id);

    }
}
