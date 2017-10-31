using Northwind.Domain.Products;
using System;
using System.Collections.Generic;
using Northwind.Framework.Helpers;
using Northwind.Application.Services;
using Northwind.Framework.Domain;

namespace Northwind.Application.Products
{
    public class ProductService : ServiceBase, IDomainService
    {
        private readonly IProductRepository _repo;
        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }
    }
}
