using ArmyTechTask.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ArmyTechTask.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ArmyTechTaskContext context;
        public GenericRepository(ArmyTechTaskContext context)
        {
            this.context = context;
        }
        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
        }
        public void AddRange(IEnumerable<T> entities)
        {
            context.Set<T>().AddRange(entities);
        }
        public void Update(T entity)
        {
            context.Set<T>().Update(entity);
        }
        public IEnumerable<T> Find<TProperty>(Expression<Func<T, bool>> where = null, params Expression<Func<T, object>>[] navigationProperties)
        {
            IQueryable<T> dbQuery = context.Set<T>();

            if (navigationProperties != null)
                foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                    dbQuery = dbQuery.Include(navigationProperty);
            if (where != null)
                dbQuery = dbQuery.Where(where);
            return dbQuery.ToList();
        }
        public IEnumerable<T> GetAll(params Expression<Func<T, object>>[] navigationProperties)
        {
            IQueryable<T> dbQuery = context.Set<T>();
            if (navigationProperties != null)
                foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                    dbQuery = dbQuery.Include(navigationProperty);
            return dbQuery.ToList();
        }
        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }
        public void Remove(T entity)
        {
            context.Set<T>().Remove(entity);
        }
        public void RemoveRange(IEnumerable<T> entities)
        {
            context.Set<T>().RemoveRange(entities);
        }
        public void Include<TProperty>(Expression<Func<T, TProperty>> navigationPropertyPath)
        {
            context.Set<T>().Include(navigationPropertyPath);
        }
    }
}
