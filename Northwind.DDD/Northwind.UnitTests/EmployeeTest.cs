using Microsoft.VisualStudio.TestTools.UnitTesting;
using Northwind.Application.Employees;
using Northwind.Application.Services;

namespace Northwind.UnitTests
{
    [TestClass]
    public class EmployeeTest : UnitTestBase
    {
        [TestMethod]
        public void GetEmployeeById()
        {
            var expectedFullName = "Nancy Davolio";
            var repo = new EmployeeRepository(UnitOfWork);
            var service = new EmployeeService(repo);
            var employee = service.GetEmployeeById(1);
            var result = $"{employee.FirstName} {employee.LastName}";
            Assert.AreEqual(expectedFullName, result);
        }
    }
}
