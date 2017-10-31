using Northwind.Domain.Suppliers;
using System;
using System.Collections.Generic;
using System.Text;
using Northwind.Framework.Helpers;

namespace Northwind.Application.Services
{
    public class SupplierService : ISupplierRepository
    {
        public IEnumerable<Supplier> Find(IFilter<Supplier> filter)
        {
            throw new NotImplementedException();
        }

        public Supplier FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Supplier FindSingle(IFilter<Supplier> spec)
        {
            throw new NotImplementedException();
        }

        public void Remove(Supplier entity)
        {
            throw new NotImplementedException();
        }

        public void Save(Supplier entity)
        {
            throw new NotImplementedException();
        }
    }
}
