using Northwind.Application.Services;
using Northwind.Domain.OrderDetails;
using Northwind.Framework.Domain;
using Northwind.Framework.Helpers;

namespace Northwind.Application.OrderDetails
{
    public class OrderDetailService : IDomainService
    {
        private readonly IOrderDetailRepository _repo;
        private readonly IUnitOfWork _unitOfWork;

        public OrderDetailService(IOrderDetailRepository repo, IUnitOfWork unitOfWork)
        {
            _repo = repo;
            _unitOfWork = unitOfWork;
        }
    }
}
