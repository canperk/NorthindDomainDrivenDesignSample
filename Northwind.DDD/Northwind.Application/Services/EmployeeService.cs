using Northwind.Domain.Employees;
using Northwind.Framework.Domain;
using Northwind.Framework.Helpers;
using System;
using System.Collections.Generic;

namespace Northwind.Application.Services
{
    public class EmployeeService : IDomainService, IEmployeeRepository
    {
        private readonly IUnitOfWork unitOfWork;
        public EmployeeService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
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

        public IEnumerable<Employee> GetEmployeesByCountry(string countryName)
        {
            throw new NotImplementedException();
        }

        public Employee GetManager(long employeeId)
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
