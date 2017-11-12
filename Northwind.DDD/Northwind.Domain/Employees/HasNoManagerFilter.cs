using Northwind.Framework.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using Northwind.Framework.Helpers.Filters;

namespace Northwind.Domain.Employees
{
    public class HasNoManagerFilter : FilterBase<Employee>
    {
        public override Expression<Func<Employee, bool>> FilterExpression => i => i.ManagerId.HasValue;
    }
}
