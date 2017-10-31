using Northwind.Application.Services;
using Northwind.Domain.Orders;
using Northwind.Framework.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Application.Orders
{
    public class OrderService : ServiceBase, IDomainService
    {
        private readonly IOrderRepository _repo;
        public OrderService(IOrderRepository repo)
        {
            _repo = repo;
        }
    }
}
