using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;

namespace Infrastructure
{
    public class DbContextUnitOfWork<T> : IUnitOfWork where T : DbContext , new()
    {
        internal readonly DbContext Context;
        public DbContextUnitOfWork()
        {
            Context = new T();

        }

        public ICollection<ValidationResult> Commit()
        {
            var validationResults = new List<ValidationResult>();

            try
            {
                Context.SaveChanges();
            }
            catch (DbEntityValidationException dbe)
            {
                foreach (var validation in dbe.EntityValidationErrors)
                {
                    var validations = validation.ValidationErrors.Select(
                        error => new ValidationResult(
                            error.ErrorMessage,
                            new[]
                            {
                                error.PropertyName
                            }));

                    validationResults.AddRange(validations);

                    return validationResults;
                }
            }
            return validationResults;
        }

        IRepository<TEntity> IUnitOfWork.GetRepository<TEntity>()
        {
            return GetRepository<TEntity>();
        }

        public DbContextRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            return new DbContextRepository<TEntity>(Context);
        }


        public void Dispose()
        {
            Context.Dispose();
        }
    }
}