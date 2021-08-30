﻿using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository.EFRepository
{
    public class EFRepositoryBase<TEntity, IContext> : IRepository<TEntity>
        where TEntity : class, IEntity, new()
        where IContext : DbContext, new()

    {
        protected readonly IContext Context;

        public EFRepositoryBase(IContext context)
        {
            Context = context;
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter = null)
        {
           await using(var context = Context)
            {
                return filter == null
                    ? await context.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync()
                    : await context.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(filter);
            }
        }
        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            await using (var context= Context)
            {
                if (filter==null)
                {
                    return await context.Set<TEntity>().AsNoTracking().ToListAsync();
                }
                return await context.Set<TEntity>().AsNoTracking().Where(filter).ToListAsync();
            }
        }

        public async Task<bool> AddAsync(TEntity entity)
        {
            await using (var context = Context)
            {
                await using var dbContextTransaction = await context.Database.BeginTransactionAsync();
                try
                {
                    await context.Set<TEntity>().AddAsync(entity);
                    await context.SaveChangesAsync();
                    await dbContextTransaction.CommitAsync();
                    return true;
                }
                catch (Exception)
                {
                    await dbContextTransaction.RollbackAsync();
                    throw;
                }
            }
               
        }
        public async Task<object> AddReturnEntityAsync(TEntity entity)
        {
            await using (var context = Context)
            {
                await using var dbContextTransaction = await context.Database.BeginTransactionAsync();
                try
                {
                  var returnEntity=  await context.Set<TEntity>().AddAsync(entity);
                    await context.SaveChangesAsync();
                    await dbContextTransaction.CommitAsync();
                    return  returnEntity;
                }
                catch (Exception)
                {
                    await dbContextTransaction.RollbackAsync();
                    throw;
                }
            }

        }

        public async Task<bool> DeleteAsync(TEntity entity)
        {
            await using (var context = Context)
            {
                await using var dbContextTransaction = await context.Database.BeginTransactionAsync();
                try
                {
                    context.Set<TEntity>().Remove(entity);
                    await context.SaveChangesAsync();
                    await dbContextTransaction.CommitAsync();
                    return true;
                }
                catch (Exception)
                {
                    await dbContextTransaction.RollbackAsync();
                    throw;
                }
            }
        }

        public async Task<bool> UpdateAsync(TEntity entity)
        {
            await using (var context = Context)
            {
                await using var dbContextTransaction = await context.Database.BeginTransactionAsync();
                try
                {
                    context.Set<TEntity>().Update(entity);
                    await context.SaveChangesAsync();
                    await dbContextTransaction.CommitAsync();
                    return true;
                }
                catch (Exception)
                {
                    await dbContextTransaction.RollbackAsync();
                    throw;
                }
            }
        }
        public async Task<bool> UpdateWithEntryAsync(TEntity entity, params object[] propertyNames)
        {
            await using (var context = Context)
            {
                await using var dbContextTransaction = await context.Database.BeginTransactionAsync();
                try
                {
                    context.Entry(entity).State = EntityState.Modified;
                    for (int i = 0; i < propertyNames.Count(); i++)
                    {
                        context.Entry(entity).Property(propertyNames[i].ToString()).IsModified = false;

                        foreach (var p in context.Entry(propertyNames[i].ToString()).Properties.Where(p => p.Metadata.Name != "Label"))
                            p.IsModified = false;
                    }
                    await context.SaveChangesAsync();
                    await dbContextTransaction.CommitAsync();
                    return true;
                }
                catch (Exception)
                {
                    await dbContextTransaction.RollbackAsync();
                    throw;
                }
            }
        }
    }
}
