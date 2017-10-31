using Northwind.Application.Services;
using Northwind.Domain.Customers;
using Northwind.Framework.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Application.Customers
{
    public class CustomerService : ServiceBase, IDomainService
    {
        private readonly ICustomerRepository _repo;

        public CustomerService(ICustomerRepository repo)
        {
            _repo = repo;
        }
    }
}
