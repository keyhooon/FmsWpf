using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Infrastructure
{
    public class DbContextRepository<TEntity> :
        IDisposable, IRepository<TEntity> where TEntity : class
    {

        public DbContextRepository(DbContext context)
        {
            Context = context;
            DbSet = Context.Set<TEntity>();
        }

        internal readonly DbContext Context;
        internal readonly DbSet<TEntity> DbSet;

        public virtual IQueryable<TEntity> GetAll()
        {

            var query = Context.Set<TEntity>();
            return query;
        }

        public virtual TEntity GetByID(object id)
        {
            return DbSet.Find(id);
        }

        public virtual IQueryable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TEntity> query = DbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query);
            }
            else
            {
                return query;
            }
        }
        public IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
        {

            var query = DbSet.Where(predicate);
            return query;
        }

        public virtual void Add(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            if (Context.Entry(entity).State == EntityState.Detached)
            {
                DbSet.Attach(entity);
            }
            DbSet.Remove(entity);
        }
        public virtual void Delete(object id)
        {
            TEntity entityToDelete = DbSet.Find(id);
            Delete(entityToDelete);
        }


        public virtual void Edit(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Save()
        {
            Context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
