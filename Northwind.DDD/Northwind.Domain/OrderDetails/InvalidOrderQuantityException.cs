using Northwind.Framework.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Domain.OrderDetails
{
    public class InvalidOrderQuantityException : OperationalException
    {
        public InvalidOrderQuantityException()
        {
            Type = ExceptionType.InvalidOrderQuantityException;
        }
    }
}
