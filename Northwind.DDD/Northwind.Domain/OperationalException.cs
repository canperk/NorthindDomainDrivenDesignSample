using System;

namespace Northwind.Domain
{
    public abstract class OperationalException : Exception
    {
        public ExceptionType Type { get; set; }
    }
}
