using Core.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ISecondNavbarDal : IRepository<SecondNavbar>
    {
        Task<List<SecondNavbar>> GetSecondNavbarAsync(string languageCode);

    }
}
