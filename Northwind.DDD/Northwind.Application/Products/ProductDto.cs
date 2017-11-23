using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Application.Products
{
    public class ProductDto
    {
        public long Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public double UnitsInStock { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
    }
}
