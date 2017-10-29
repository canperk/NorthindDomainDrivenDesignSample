using System;
using System.Linq.Expressions;

namespace Northwind.Framework.Helpers.Filters
{
    public abstract class FilterBase<T> : IFilter<T>
    {
        private Func<T, bool> _compiledExpression;
        private Func<T, bool> CompiledExpression
        {
            get { return _compiledExpression ?? (_compiledExpression = FilterExpression.Compile()); }
        }
        public abstract Expression<Func<T, bool>> FilterExpression { get; }
        public bool IsFilteredBy(T obj)
        {
            return CompiledExpression(obj);
        }
    }
}
