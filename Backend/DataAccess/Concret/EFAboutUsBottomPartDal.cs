﻿using Core.Repository.EFRepository;
using DataAccess.Abstract;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concret
{
    public class EFAboutUsBottomPartDal : EFRepositoryBase<AboutUsBottomPart, AppDbContext>, IAboutUsBottomPartDal
    {
        public async Task<List<AboutUsBottomPart>> GetAboutUsBottomPartAsync(string languageCode)
        {
            await using var context = new AppDbContext();
            return await context.AboutUsBottomParts.Include(x => x.Language)
                .Where(x => x.IsDeleted == false && x.Language.Code == languageCode)
                .ToListAsync();
        }
    }
}