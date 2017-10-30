using Northwind.Framework.Domain;
using System;

namespace Northwind.Domain.Products
{
    [Serializable]
    internal class InvalidStockException : OperationalException
    {
        public InvalidStockException()
        {
            Type = ExceptionType.InvalidStock;
        }
    }
}