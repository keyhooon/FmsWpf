using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        ICollection<ValidationResult> Commit();

        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
    }
}
