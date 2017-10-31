using Northwind.Domain.Products;
using System;
using System.Collections.Generic;
using System.Text;
using Northwind.Framework.Helpers;

namespace Northwind.Application.Services
{
    public class ProductService : ServiceBase, IProductRepository
    {
        public IEnumerable<Product> Find(IFilter<Product> filter)
        {
            throw new NotImplementedException();
        }

        public Product FindById(long id)
        {
            throw new NotImplementedException();
        }

        public Product FindSingle(IFilter<Product> spec)
        {
            throw new NotImplementedException();
        }

        public void Remove(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Save(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
