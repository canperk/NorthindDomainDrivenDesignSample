using Northwind.Application.Services;
using Northwind.Domain.OrderDetails;
using Northwind.Framework.Domain;

namespace Northwind.Application.OrderDetails
{
    public class OrderDetailService : ServiceBase, IDomainService
    {
        private readonly IOrderDetailRepository _repo;
        public OrderDetailService(IOrderDetailRepository repo)
        {
            _repo = repo;
        }
    }
}
