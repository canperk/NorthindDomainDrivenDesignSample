using Northwind.Framework.Helpers;
using System;
using System.Collections.Generic;

namespace Northwind.Domain.Customers
{
    public class CustomerRepository : IRepository<Customer, string>
    {
        public IEnumerable<Customer> Find(IFilter<Customer> filter)
        {
            throw new NotImplementedException();
        }

        public Customer FindById(string id)
        {
            throw new NotImplementedException();
        }

        public Customer FindSingle(IFilter<Customer> spec)
        {
            throw new NotImplementedException();
        }

        public void Remove(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Save(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
