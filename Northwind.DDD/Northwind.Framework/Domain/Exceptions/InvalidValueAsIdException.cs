using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Framework.Domain.Exceptions
{
    public class InvalidValueAsIdException : OperationalException
    {
        public InvalidValueAsIdException()
        {
            Type = ExceptionType.InvalidId;
        }
    }
}
