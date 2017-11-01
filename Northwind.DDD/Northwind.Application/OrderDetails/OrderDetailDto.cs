using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Application.OrderDetails
{
    public class OrderDetailDto
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public long ProductId { get; set; }
        public decimal Price { get; set; }
        public double Quantity { get; set; }
        public double Discount { get; set; }
    }
}
