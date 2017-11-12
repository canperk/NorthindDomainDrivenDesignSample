using Northwind.Framework.Helpers.Filters;
using System;
using System.Linq.Expressions;

namespace Northwind.Domain.Employees
{
    public class HasManagerFilter : FilterBase<Employee>
    {
        public override Expression<Func<Employee, bool>> FilterExpression => i => i.ManagerId.HasValue;
    }
}
