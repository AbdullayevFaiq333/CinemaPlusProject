﻿using Core.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IMovieFormatDal : IRepository<MovieFormat>
    {
        Task<bool> CheckMovieFormat(Expression<Func<MovieFormat, bool>> expression);

    }
}
