using Northwind.Application.Mappers;
using Northwind.Domain.Categories;
using Northwind.Domain.Products;
using Northwind.Framework.Domain;
using Northwind.Framework.Helpers;
using System.Collections.Generic;

namespace Northwind.Application.Categories
{
    public class CategoryService : IDomainService
    {
        private readonly ICategoryRepository _repo;
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(ICategoryRepository repo, IUnitOfWork unitOfWork)
        {
            _repo = repo;
            _unitOfWork = unitOfWork;
        }

        public bool HasProducts(CategoryDto category)
        {
            return true;
        }

        public CategoryDto GetById(int id)
        {
            var category = _repo.FindById(id);
            return CategoryMapper.Instance.ToDto(category);
        }

        public IEnumerable<Product> GetProducts(CategoryDto category)
        {
            var entity = CategoryMapper.Instance.ToEntity(category);
            return _repo.GetProducts(entity);
        }
    }
}
