using Northwind.Framework.Helpers;
using System.Collections.Generic;

namespace Northwind.Domain.Employees
{
    public interface IEmployeeRepository : IRepository<Employee, int>
    {
        IEnumerable<Employee> GetEmployeesByCountry(string countryName);
        Employee GetManager(int employeeId);
    }
}
