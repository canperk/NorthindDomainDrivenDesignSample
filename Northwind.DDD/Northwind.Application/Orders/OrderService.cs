using Northwind.Domain.Orders;
using Northwind.Framework.Domain;
using Northwind.Framework.Helpers;

namespace Northwind.Application.Orders
{
    public class OrderService : IDomainService
    {
        private readonly IOrderRepository _repo;
        private readonly IUnitOfWork _unitOfWork;

        public OrderService(IOrderRepository repo, IUnitOfWork unitOfWork)
        {
            _repo = repo;
            _unitOfWork = unitOfWork;
        }
    }
}
