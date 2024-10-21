using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace Metek.Persistence.Repositories
{
    public class EfRepositoryBase<TEntity, TEntityId, TContext> : IAsyncRepository<TEntity, TEntityId>, IRepository<TEntity, TEntityId> where TEntity : Entity<TEntityId> where TContext : DbContext
    {
        protected readonly TContext Context;

        public EfRepositoryBase(TContext context)
        {
            Context = context;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            entity.CreatedDate = DateTime.UtcNow;
            await Context.AddAsync(entity);
            await Context.SaveChangesAsync();
            return entity;
        }
        public List<TEntity> GetListByDynamic(Expression<Func<TEntity, bool>>? predicate = null,
                                              Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
                                              int index = 0, int size = 10,
                                              bool withDeleted = false,
                                              bool enableTracking = true)
        {
            IQueryable<TEntity> queryable = Query();

            if (!enableTracking)
                queryable = queryable.AsNoTracking();

            if (include != null)
                queryable = include(queryable);

            if (withDeleted)
                queryable = queryable.IgnoreQueryFilters();

            if (predicate != null)
                queryable = queryable.Where(predicate);

            // Implement pagination logic
            return queryable.Skip(index * size).Take(size).ToList();
        }

        public async Task<ICollection<TEntity>> AddRangeAsync(ICollection<TEntity> entities)
        {
            foreach (TEntity entity in entities)
            {
                entity.CreatedDate = DateTime.UtcNow;
            }
            await Context.AddRangeAsync(entities);
            await Context.SaveChangesAsync();
            return entities;
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>>? predicate = null, bool withDeleted = false, bool enableTracking = true, CancellationToken cancellationToken = default)
        {
            IQueryable<TEntity> queryable = Query();
            if (!enableTracking)
            {
                queryable = queryable.AsNoTracking();
            }
            if (withDeleted)
            {
                queryable = queryable.IgnoreQueryFilters();
            }
            if (predicate != null)
            {
                queryable = queryable.Where(predicate);
            }
            return await queryable.AnyAsync(cancellationToken);
        }

        public async Task<TEntity> DeleteAsync(TEntity entity, bool permanent = false)
        {
            if (permanent)
            {
                Context.Remove(entity);
            }
            else
            {
                entity.DeletedDate = DateTime.UtcNow;
                Context.Update(entity);
            }
            await Context.SaveChangesAsync();
            return entity;
        }

        public async Task<ICollection<TEntity>> DeleteRangeAsync(ICollection<TEntity> entities, bool permanent = false)
        {
            if (permanent)
            {
                Context.RemoveRange(entities);
            }
            else
            {
                foreach (TEntity entity in entities)
                {
                    entity.DeletedDate = DateTime.UtcNow;
                }
                Context.UpdateRange(entities);
            }
            await Context.SaveChangesAsync();
            return entities;
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, bool withDeleted = false, bool enableTracking = true, CancellationToken cancellationToken = default)
        {
            IQueryable<TEntity> queryable = Query();
            if (!enableTracking)
                queryable = queryable.AsNoTracking();
            if (include != null)
                queryable = include(queryable);
            if (withDeleted)
                queryable = queryable.IgnoreQueryFilters();
            return await queryable.FirstOrDefaultAsync(predicate, cancellationToken);
        }

        public async Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>>? predicate = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, int index = 0, int size = 10, bool withDeleted = false, bool enableTracking = true, CancellationToken cancellationToken = default)
        {
            IQueryable<TEntity> queryable = Query();
            if (!enableTracking)
                queryable = queryable.AsNoTracking();
            if (include != null)
                queryable = include(queryable);
            if (withDeleted)
                queryable = queryable.IgnoreQueryFilters();
            if (predicate != null)
                queryable = queryable.Where(predicate);
            if (orderBy != null)
                return await orderBy(queryable).Skip(index * size).Take(size).ToListAsync(cancellationToken);
            return await queryable.Skip(index * size).Take(size).ToListAsync(cancellationToken);
        }

        public IQueryable<TEntity> Query() => Context.Set<TEntity>();

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            entity.UpdatedDate = DateTime.UtcNow;
            Context.Update(entity);
            await Context.SaveChangesAsync();
            return entity;
        }

        public async Task<ICollection<TEntity>> UpdateRangeAsync(ICollection<TEntity> entities)
        {
            foreach (var entity in entities)
                entity.UpdatedDate = DateTime.UtcNow;
            Context.UpdateRange(entities);
            await Context.SaveChangesAsync();
            return entities;
        }

        protected IQueryable<object> GetRelationLoaderQuery(IQueryable query, Type navigationPropertyType)
        {
            Type queryProviderType = query.Provider.GetType();
            MethodInfo createQueryMethod =
                queryProviderType
                    .GetMethods()
                    .First(m => m is { Name: nameof(query.Provider.CreateQuery), IsGenericMethod: true })
                    ?.MakeGenericMethod(navigationPropertyType)
                ?? throw new InvalidOperationException("CreateQuery<TElement> method is not found in IQueryProvider.");
            var queryProviderQuery =
                (IQueryable<object>)createQueryMethod.Invoke(query.Provider, parameters: new object[] { query.Expression })!;
            return queryProviderQuery.Where(x => !((IEntityTimestamps)x).DeletedDate.HasValue);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, bool withDeleted = false, bool enableTracking = true)
        {
            IQueryable<TEntity> queryable = Query();
            if (!enableTracking)
                queryable = queryable.AsNoTracking();
            if (include != null)
                queryable = include(queryable);
            if (withDeleted)
                queryable = queryable.IgnoreQueryFilters();
            return queryable.FirstOrDefault(predicate);
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>>? predicate = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, int index = 0, int size = 10, bool withDeleted = false, bool enableTracking = true)
        {
            IQueryable<TEntity> queryable = Query();
            if (!enableTracking)
                queryable = queryable.AsNoTracking();
            if (include != null)
                queryable = include(queryable);
            if (withDeleted)
                queryable = queryable.IgnoreQueryFilters();
            if (predicate != null)
                queryable = queryable.Where(predicate);
            if (orderBy != null)
                return orderBy(queryable).Skip(index * size).Take(size).ToList();
            return queryable.ToList();
        }

        public bool Any(Expression<Func<TEntity, bool>>? predicate = null, bool withDeleted = false, bool enableTracking = true)
        {
            IQueryable<TEntity> queryable = Query();
            if (!enableTracking)
                queryable = queryable.AsNoTracking();
            if (withDeleted)
                queryable = queryable.IgnoreQueryFilters();
            if (predicate != null)
                queryable = queryable.Where(predicate);
            return queryable.Any();
        }

        public TEntity Add(TEntity entity)
        {
            entity.CreatedDate = DateTime.UtcNow;
            Context.Add(entity);
            Context.SaveChanges();
            return entity;
        }

        public ICollection<TEntity> AddRange(ICollection<TEntity> entities)
        {
            foreach (TEntity entity in entities)
            {
                entity.CreatedDate = DateTime.UtcNow;
            }
            Context.AddRange(entities);
            Context.SaveChanges();
            return entities;
        }

        public TEntity Update(TEntity entity)
        {
            entity.UpdatedDate = DateTime.UtcNow;
            Context.Update(entity);
            Context.SaveChanges();
            return entity;
        }

        public ICollection<TEntity> UpdateRange(ICollection<TEntity> entities)
        {
            foreach (var entity in entities)
                entity.UpdatedDate = DateTime.UtcNow;
            Context.UpdateRange(entities);
            Context.SaveChanges();
            return entities;
        }

        public TEntity Delete(TEntity entity, bool permanent = false)
        {
            if (permanent)
            {
                Context.Remove(entity);
            }
            else
            {
                entity.DeletedDate = DateTime.UtcNow;
                Context.Update(entity);
            }
            Context.SaveChanges();
            return entity;
        }

        public ICollection<TEntity> DeleteRange(ICollection<TEntity> entities, bool permanent = false)
        {
            if (permanent)
            {
                Context.RemoveRange(entities);
            }
            else
            {
                foreach (TEntity entity in entities)
                {
                    entity.DeletedDate = DateTime.UtcNow;
                }
                Context.UpdateRange(entities);
            }
            Context.SaveChanges();
            return entities;
        }

     
    }
}

