using System.Collections.Generic;
using Northwind.Domain.Categories;
using Northwind.Framework.Domain;
using Northwind.Framework.Helpers;

namespace Northwind.Application.Services
{
    internal class CategoryService : ServiceBase, IDomainService, ICategoryRepository
    {
        public IEnumerable<Category> Find(IFilter<Category> filter)
        {
            throw new System.NotImplementedException();
        }

        public Category FindById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Category FindSingle(IFilter<Category> spec)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(Category entity)
        {
            throw new System.NotImplementedException();
        }

        public void Save(Category entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
