using Northwind.Domain.Customers;
using Northwind.Framework.Domain;
using Northwind.Framework.Helpers;

namespace Northwind.Application.Customers
{
    public class CustomerService : IDomainService
    {
        private readonly ICustomerRepository _repo;
        private readonly IUnitOfWork _unitOfWork;

        public CustomerService(ICustomerRepository repo, IUnitOfWork unitOfWork)
        {
            _repo = repo;
            _unitOfWork = unitOfWork;
        }
    }
}
