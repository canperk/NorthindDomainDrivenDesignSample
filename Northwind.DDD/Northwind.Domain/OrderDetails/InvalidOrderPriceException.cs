using Northwind.Framework.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Domain.OrderDetails
{
    public class InvalidOrderPriceException : OperationalException
    {
        public InvalidOrderPriceException()
        {
            Type = ExceptionType.InvalidOrderPriceException;
        }
    }
}
