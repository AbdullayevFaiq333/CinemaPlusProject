﻿using Core.Repository.EFRepository;
using DataAccess.Abstract;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concret
{
    public class EFNewsDal : EFRepositoryBase<News, AppDbContext>, INewsDal
    {
        public EFNewsDal(AppDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<bool> CheckNews(Expression<Func<News, bool>> expression)
        {
            return await Context.News.AnyAsync(expression);
        }
        public async Task<List<News>> GetNewsAsync(string languageCode)
        {
            return await Context.News.Include(x => x.Language)
                .Where(x => x.Language.Code == languageCode)
                .ToListAsync();
        }
    }
}
