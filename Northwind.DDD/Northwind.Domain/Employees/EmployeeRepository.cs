using Northwind.Framework.Helpers;
using System;
using System.Collections.Generic;

namespace Northwind.Domain.Employees
{
    public class EmployeeRepository : IRepository<Employee, long>
    {
        public IEnumerable<Employee> Find(IFilter<Employee> filter)
        {
            throw new NotImplementedException();
        }

        public Employee FindById(long id)
        {
            throw new NotImplementedException();
        }

        public Employee FindSingle(IFilter<Employee> spec)
        {
            throw new NotImplementedException();
        }

        public void Remove(Employee entity)
        {
            throw new NotImplementedException();
        }

        public void Save(Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
