using Northwind.Domain.Products;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Northwind.Framework.Helpers;
using System.Linq;
using Northwind.Framework.Domain.Exceptions;

namespace Northwind.Application.Products
{
    internal class ProductRepository : IProductRepository
    {
        private readonly IUnitOfWork _unitOfwork;
        public ProductRepository(IUnitOfWork unitOfwork)
        {
            _unitOfwork = unitOfwork;
        }
        public DbSet<Product> Repository => _unitOfwork.GetDbSet<Product>();

        public IEnumerable<Product> Find(IFilter<Product> filter)
        {
            var items =  Repository.Where(filter.FilterExpression).ToList();
            return items;
        }

        public Product FindById(long id)
        {
            var product = Repository.FirstOrDefault(i => i.Id == id);
            if (product == null)
            {
                throw new NotFoundByIdException();
            }
            return product;
        }

        public Product FindSingle(IFilter<Product> spec)
        {
            return Repository.Where(spec.FilterExpression).SingleOrDefault();
        }

        public void Remove(Product entity)
        {
            Repository.Remove(entity);
        }

        public void Save(Product entity)
        {
            Repository.Add(entity);
        }
    }
}
