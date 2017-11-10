using Northwind.Domain.Products;
using Northwind.Framework.Helpers;
using Northwind.Framework.Domain;

namespace Northwind.Application.Products
{
    public class ProductService : IDomainService
    {
        private readonly IProductRepository _repo;
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IProductRepository repo, IUnitOfWork unitOfWork)
        {
            _repo = repo;
            _unitOfWork = unitOfWork;
        }
    }
}
