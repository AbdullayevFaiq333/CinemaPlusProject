﻿using Core.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBranchDal : IRepository<Branch>
    {
        Task<List<Branch>> GetBranchAsync(string languageCode,int id);
    }
}
