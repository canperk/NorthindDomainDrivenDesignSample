using Microsoft.VisualStudio.TestTools.UnitTesting;
using Northwind.Application.Services;

namespace Northwind.UnitTests
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void GetEmployeeById()
        {
            var expectedFullName = "Nancy Davolio";
            var service = new EmployeeService();
            var employee = service.FindById(1);
            var result = $"{employee.FirstName} {employee.LastName}";
            Assert.AreEqual(expectedFullName, result);
        }
    }
}
