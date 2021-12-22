using Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repostory
{
    public class BaseRepostory<T> : IBaseRepostory<T> where T : class
    {
        protected Project_Context _Context;
        public BaseRepostory(Project_Context Context)
        {
            _Context = Context;
        }

        public async Task<IEnumerable<T>> GetAll(string[] includes = null, int? take = null, int? skip = null, Expression<Func<T, object>> orderBy = null, string orderByDirection = "ASC") {

            IQueryable<T> query = _Context.Set<T>();
            if (includes != null)
            {
                foreach (var include in includes)
                    query = query.Include(include);

            }
            if (take.HasValue)
                query.Take(take.Value);
            if (skip.HasValue)
                query.Skip(skip.Value);
            if (orderBy != null)
            {
                if (orderByDirection == OrderBy.Ascending)
                    query.OrderBy(orderBy);
                else
                    query.OrderByDescending(orderBy);


            }

            return await query.ToListAsync();
        }
        public async Task<T> GetByID(int id) => await _Context.Set<T>().FindAsync(id);

        public async Task<IEnumerable<T>> FindAll(Expression<Func<T, bool>> match, string[] includes = null,
            int? take = null, int? skip = null, Expression<Func<T, object>> orderBy = null, string orderByDirection = "ASC")
        {
            IQueryable<T> query = _Context.Set<T>().Where(match);
            if (includes != null)
            {
                foreach (var include in includes)
                    query = query.Include(include);

            }
            if(take.HasValue)
                 query.Take(take.Value);
            if (skip.HasValue)
                query.Skip(skip.Value);
            if (orderBy != null)
            {
                if (orderByDirection == OrderBy.Ascending)
                    query.OrderBy(orderBy); 
                else
                    query.OrderByDescending(orderBy);


            }

            return await query.ToListAsync();

        }

        public async Task<T> Add(T entity)
        {
           await _Context.Set<T>().AddAsync(entity);
            return entity;
        }

        public T Update(T entity)
        {
             _Context.Set<T>().Update(entity);

            return  entity;

        }

        public  void Delete(T entity)
        {
            _Context.Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            _Context.Set<T>().RemoveRange(entities);
        }

        public void Attach(T entity)
        {
            _Context.Set<T>().Attach(entity);
        }

        public void AttachRange(IEnumerable<T> entities)
        {
            _Context.Set<T>().AttachRange(entities);
        }

        public int Count()
        {
            return _Context.Set<T>().Count();
        }

     

        public async Task<int> CountAsync(Expression<Func<T, bool>> criteria)
        {
            return await _Context.Set<T>().CountAsync(criteria);
        }

      
    }
} 
