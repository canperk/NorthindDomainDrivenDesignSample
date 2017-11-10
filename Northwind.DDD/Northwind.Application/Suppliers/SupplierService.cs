using Northwind.Domain.Suppliers;
using Northwind.Framework.Helpers;
using Northwind.Framework.Domain;

namespace Northwind.Application.Suppliers
{
    public class SupplierService : IDomainService
    {
        private readonly ISupplierRepository _repo;
        private readonly IUnitOfWork _unitOfWork;

        public SupplierService(ISupplierRepository repo, IUnitOfWork unitOfWork)
        {
            _repo = repo;
            _unitOfWork = unitOfWork;
        }
    }
}
