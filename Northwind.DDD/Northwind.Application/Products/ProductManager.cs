using Northwind.Domain.Products;
using Northwind.Framework.Helpers;
using Northwind.Framework.Domain;
using Northwind.Domain.Categories;
using System.Collections.Generic;
using Northwind.Framework;
using System.Linq;
using Northwind.Application.Mappers;

namespace Northwind.Application.Products
{
    public class ProductManager : IDomainService
    {
        private readonly IProductRepository _repo;
        private readonly IUnitOfWork _unitOfWork;

        public ProductManager(IProductRepository repo, IUnitOfWork unitOfWork)
        {
            _repo = repo;
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<ProductDto> GetProductsByCategory(Category category)
        {
            TypeCheck.IsNull(category);
            TypeCheck.IsUsableAsId(category.Id);
            var filter = new ProductByCategoryFilter(category.Id);
            return _repo.Find(filter).Select(i => i.ToDto());
        }
    }
}
