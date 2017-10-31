using Northwind.Domain.Suppliers;
using System;
using System.Collections.Generic;
using System.Text;
using Northwind.Framework.Helpers;
using Northwind.Application.Services;
using Northwind.Framework.Domain;

namespace Northwind.Application.Suppliers
{
    public class SupplierService : ServiceBase, IDomainService
    {
        private readonly ISupplierRepository _repo;

        public SupplierService(ISupplierRepository repo)
        {
            _repo = repo;
        }
    }
}
