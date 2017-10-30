using Northwind.Framework.Domain;

namespace Northwind.Domain.Products
{
    public class InvalidPriceException : OperationalException
    {
        public InvalidPriceException()
        {
            Type = ExceptionType.InvalidPrice;
        }
    }
}
