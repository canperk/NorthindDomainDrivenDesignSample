using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Application.Orders
{
    public class OrderDto
    {
        public long Id { get; set; }
        public string CustomerId { get; set; }
        public bool IsUrgent { get; set; }
        public DateTime? LastShipDate { get; set; }
    }
}
