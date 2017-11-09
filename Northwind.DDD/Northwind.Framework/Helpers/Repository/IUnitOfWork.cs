using Microsoft.EntityFrameworkCore;
using Northwind.Framework.Entity;
using System;

namespace Northwind.Framework.Helpers
{
    public interface IUnitOfWork : IDisposable
    {
        DbSet<T> GetDbSet<T>() where T : EntityBase;
        void Commit();
        void Rollback();
    }
}
