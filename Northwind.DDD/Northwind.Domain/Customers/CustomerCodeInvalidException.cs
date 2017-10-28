using System;

namespace Northwind.Domain.Customers
{
    [Serializable]
    internal class CustomerCodeInvalidException : OperationalException
    {
        public CustomerCodeInvalidException()
        {
            Type = ExceptionType.InvalidCustomerCode;
        }
    }
}