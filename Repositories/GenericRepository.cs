using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace qvisitorCorp.Repositories
{
    public abstract class GenericRepository<C, T> : IGenericRepository<T> 
    where T : class
    where C : DbContext 
    {

        private readonly C _ctx;
       
        public GenericRepository(C ctx)
        {
            _ctx = ctx;
        }

        public virtual IQueryable<T> GetAll() {

            IQueryable<T> query = _ctx.Set<T>();
            return query;
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate) {

            IQueryable<T> query = _ctx.Set<T>().Where(predicate);
            return query;
        }

        public virtual void Add(T entity) {
            _ctx.Set<T>().Add(entity);
        }

        public virtual void Delete(T entity) {
            _ctx.Set<T>().Remove(entity);
        }

        public virtual void Edit(T entity) {
            _ctx.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Save() {
            _ctx.SaveChanges();
        }

        public T FindSingle(Expression<Func<T, bool>> predicate)
        {
            return _ctx.Set<T>().FirstOrDefault();
        }

        public bool Any(Expression<Func<T, bool>> predicate)
        {
            return _ctx.Set<T>().Any(predicate);
        }
    }
}
