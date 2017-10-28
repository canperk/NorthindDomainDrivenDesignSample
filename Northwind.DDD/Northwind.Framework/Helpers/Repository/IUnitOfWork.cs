using System;

namespace Northwind.Framework.Helpers
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
        void Rollback();
    }
}
