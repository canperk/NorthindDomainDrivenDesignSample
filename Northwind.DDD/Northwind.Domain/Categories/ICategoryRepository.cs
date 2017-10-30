using Northwind.Framework.Helpers;
using System;
using System.Collections.Generic;

namespace Northwind.Domain.Categories
{
    public interface ICategoryRepository : IRepository<Category, int>
    {
        public IEnumerable<Category> Find(IFilter<Category> filter)
        {
            throw new NotImplementedException();
        }

        public Category FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Category FindSingle(IFilter<Category> spec)
        {
            throw new NotImplementedException();
        }

        public void Remove(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Save(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
