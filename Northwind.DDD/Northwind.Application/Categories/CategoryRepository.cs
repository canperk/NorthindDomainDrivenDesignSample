using Northwind.Domain.Categories;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Northwind.Framework.Helpers;
using System.Linq;
using Northwind.Framework.Domain.Exceptions;

namespace Northwind.Application.Categories
{
    internal class CategoryRepository : ICategoryRepository
    {
        private readonly IUnitOfWork _unitOfwork;
        public CategoryRepository(IUnitOfWork unitOfwork)
        {
            _unitOfwork = unitOfwork;
        }
        public DbSet<Category> Repository => _unitOfwork.GetDbSet<Category>();
        public IEnumerable<Category> Find(IFilter<Category> filter)
        {
            return Repository.Where(filter.FilterExpression);
        }

        public Category FindById(int id)
        {
            var category = Repository.FirstOrDefault(i => i.Id == id);
            if (category == null)
            {
                throw new NotFoundByIdException();
            }
            return category;
        }

        public Category FindSingle(IFilter<Category> spec)
        {
            return Repository.Where(spec.FilterExpression).SingleOrDefault();
        }

        public void Remove(Category entity)
        {
            Repository.Remove(entity);
        }

        public void Save(Category entity)
        {
            Repository.Add(entity);
        }
    }
}
