﻿using Core.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IHallDal:IRepository<Hall>
    {
        Task<List<Hall>> GetHallAsync(string languageCode);
    }
}
