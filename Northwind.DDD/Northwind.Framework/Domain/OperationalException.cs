using System;

namespace Northwind.Framework.Domain
{
    public abstract class OperationalException : Exception
    {
        public ExceptionType Type { get; set; }
    }
}
