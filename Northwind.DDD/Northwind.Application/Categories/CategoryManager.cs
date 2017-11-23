using Northwind.Application.Mappers;
using Northwind.Application.Products;
using Northwind.Domain.Categories;
using Northwind.Domain.Products;
using Northwind.Framework.Domain;
using Northwind.Framework.Helpers;
using System.Collections.Generic;

namespace Northwind.Application.Categories
{
    public class CategoryManager : IDomainService
    {
        private readonly ICategoryRepository _categoryRepo;
        private readonly IProductRepository _productRepo;
        private readonly IUnitOfWork _unitOfWork;

        public CategoryManager(IUnitOfWork unitOfWork, ICategoryRepository categoryRepository, IProductRepository productRepository)
        {
            _categoryRepo = categoryRepository;
            _productRepo = productRepository;
            _unitOfWork = unitOfWork;
        }

        public bool HasProducts(CategoryDto category)
        {
            return true;
        }

        public CategoryDto GetById(int id)
        {
            var category = _categoryRepo.FindById(id);
            return category.ToDto();
        }

        public IEnumerable<ProductDto> GetProducts(CategoryDto category)
        {
            var entity = category.ToEntity();
            var productManager = new ProductManager(_productRepo, _unitOfWork);
            return productManager.GetProductsByCategory(entity);
        }
    }
}
