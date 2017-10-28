using System;
using System.Linq.Expressions;

namespace Northwind.Framework.Helpers
{
    public interface IFilter<T>
    {
        Expression<Func<T, bool>> FilterExpression { get; }
        bool IsFilteredBy(T obj);
    }
}
