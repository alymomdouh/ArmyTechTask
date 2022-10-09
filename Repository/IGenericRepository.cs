using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ArmyTechTask.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int id);
        public IEnumerable<T> GetAll(params Expression<Func<T, object>>[] navigationProperties);
        IEnumerable<T> Find<TProperty>(Expression<Func<T, bool>> where = null, params Expression<Func<T, object>>[] navigationProperties);
        void Add(T entity);
        void Update(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);

        // Include for navigation properties
        void Include<TProperty>(Expression<Func<T, TProperty>> navigationPropertyPath);
    }
}
