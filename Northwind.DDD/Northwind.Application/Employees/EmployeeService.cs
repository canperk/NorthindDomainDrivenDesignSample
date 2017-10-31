using Northwind.Domain.Employees;
using Northwind.Framework.Domain;
using Northwind.Framework.Helpers;
using System;
using System.Collections.Generic;

namespace Northwind.Application.Services
{
    public class EmployeeService : ServiceBase, IDomainService
    {
        private readonly IEmployeeRepository _repo;

        public EmployeeService(IEmployeeRepository repo)
        {
            _repo = repo;
        }
    }
}
