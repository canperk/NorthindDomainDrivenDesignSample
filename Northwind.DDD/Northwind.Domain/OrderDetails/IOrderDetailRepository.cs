using Northwind.Framework.Helpers;

namespace Northwind.Domain.OrderDetails
{
    public interface IOrderDetailRepository : IRepository<OrderDetail, long>
    {
    }
}
