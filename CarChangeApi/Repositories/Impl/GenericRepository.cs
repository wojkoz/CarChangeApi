using CarChangeApi.Domain.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CarChangeApi.Repositories.Impl
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly MyDBContext Context;
        protected readonly DbSet<T> Db;

        public GenericRepository(MyDBContext context)
        {
            Context = context;
            Db = Context.Set<T>();
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expression = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, IEnumerable<string> includes = null)
        {
            IQueryable<T> query = Db;

            if (expression != null)
            {
                query = query.Where(expression);
            }

            if (includes != null)
            {
                query = includes.Aggregate(query, (current, includeProperty) =>
                    current.Include(includeProperty));
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            return await query.AsNoTracking().ToListAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> expression, IEnumerable<string> includes = null)
        {
            IQueryable<T> query = Db;

            if (includes != null)
            {
                query = includes.Aggregate(query, (current, includeProperty) =>
                    current.Include(includeProperty));
            }

            return await query.AsNoTracking().FirstOrDefaultAsync(expression);
        }

        public Task InsertAsync(T entity)
        {
            Db.Add(entity);
            return Task.CompletedTask;
        }

        public Task InsertRangeAsync(IEnumerable<T> entities)
        {
            Db.AddRange(entities);
            return Task.CompletedTask;
        }

        public async Task DeleteAsync(long id)
        {
            var entity = await Db.FindAsync(id);
            Db.Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            Db.RemoveRange(entities);
        }

        public void Update(T entity)
        {
            Db.Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;
        }

        public async Task Save()
        {
            await Context.SaveChangesAsync();
        }
    }
}
