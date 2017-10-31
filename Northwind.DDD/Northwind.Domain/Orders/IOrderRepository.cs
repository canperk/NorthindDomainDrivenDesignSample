using Northwind.Framework.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Domain.Orders
{
    public interface IOrderRepository : IRepository<Order, long>
    {
    }
}
