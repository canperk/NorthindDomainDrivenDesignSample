using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Domain.Products
{
    public class ProductPolicy
    {
        public static void CheckPrice(decimal price)
        {
            if (price <= 0)
                throw new InvalidPriceException();
        }

        public static void CheckStock(double stock)
        {
            if (stock <= 0)
                throw new InvalidStockException();
        }
    }
}
