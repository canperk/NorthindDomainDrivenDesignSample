using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Northwind.Framework.Entity;
using Northwind.Framework.Helpers;
using System;

namespace Northwind.Application.Database
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
        private IDbContextTransaction _transaction;
        public UnitOfWork(DbContext context)
        {
            _context = context;
        }
        public DbSet<T> GetDbSet<T>() where T : EntityBase
        {
            return _context.Set<T>();
        }
        public void Commit()
        {
            using(_transaction = _context.Database.BeginTransaction())
            {
                _context.SaveChanges();
                _transaction.Commit();
            }
        }

        public void Dispose()
        {
            _context.Dispose();
            if (_transaction != null)
                _transaction.Dispose();
            GC.SuppressFinalize(_context);
            GC.SuppressFinalize(this);
            GC.Collect();
        }

        public void Rollback()
        {
            if(_transaction != null)
            {
                _transaction.Rollback();
                _transaction.Dispose();
            }
        }

        ~UnitOfWork()
        {
            Dispose();
        }
    }
}
