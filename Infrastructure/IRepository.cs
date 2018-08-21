using System;
using System.Linq;
using System.Linq.Expressions;

namespace Infrastructure
{
    public interface IRepository
    {
        IQueryable GetAll();
        object GetByID(object id);
        IQueryable Get(
            Expression<Func<object, bool>> filter = null,
            Func<IQueryable, IOrderedQueryable> orderBy = null,
            string includeProperties = "");
        IQueryable FindBy(Expression<Func<object, bool>> predicate);
        void Add(object entity);
        void Delete(object entity);
        void Edit(object entity);
        void Save();
    }
    public interface IRepository<T> where T : class
    {

        IQueryable<T> GetAll();
        T GetByID(object id);
        IQueryable<T> Get(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "");
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
        void Save();
    }
}
