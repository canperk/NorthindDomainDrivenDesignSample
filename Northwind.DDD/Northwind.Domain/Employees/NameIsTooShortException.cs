using Northwind.Framework.Domain;

namespace Northwind.Domain.Employees
{
    public class NameIsTooShortException : OperationalException
    {
        public NameIsTooShortException()
        {
            Type = ExceptionType.NameIsTooShort;
        }
    }
}
