using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Domain.Customers
{
    public class CustomerPolicy
    {
        public static string CheckCustomerCode(string code)
        {
            var newValue = code.Trim();
            if (newValue.Length == 0)
                throw new CustomerCodeInvalidException();
            return newValue.ToUpper();
        }
    }
}
