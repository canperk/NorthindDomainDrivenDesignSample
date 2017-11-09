using Microsoft.EntityFrameworkCore;
using Northwind.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Framework.Helpers
{
    public interface IRepository<TEntity, TKey> where TEntity : EntityBase
    {
        TEntity FindById(TKey id);
        TEntity FindSingle(IFilter<TEntity> spec);
        IEnumerable<TEntity> Find(IFilter<TEntity> filter);
        void Save(TEntity entity);
        void Remove(TEntity entity);
        DbSet<TEntity> Repository { get; }
    }
}
