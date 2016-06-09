using System;
using System.Linq;
using System.Linq.Expressions;

namespace qvisitorCorp.Repositories
{
    interface IGenericRepository<T> where T : class 
    {
        IQueryable<T> GetAll();
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);

        T FindSingle(Expression<Func<T, bool>> predicate);
        bool Any(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
        void Save();
    }
}