using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Domain.OrderDetails
{
    public class OrderDetailPolicy
    {
        public static void CheckPrice(double price)
        {
            if (price <= 0)
                throw new InvalidOrderPriceException();
        }

        public static void CheckQuantity(double quantity)
        {
            if (quantity <= 0)
                throw new InvalidOrderQuantityException();
        }
    }
}
