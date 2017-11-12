using Microsoft.VisualStudio.TestTools.UnitTesting;
using Northwind.Application.Employees;
using Northwind.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using Northwind.Domain.Employees;
using System.Linq;

namespace Northwind.UnitTests
{
    [TestClass]
    public class EmployeeTest : UnitTestBase
    {
        public EmployeeTest()
        {
            Service = new EmployeeService(_resolver.GetService<IEmployeeRepository>(), UnitOfWork);
        }
        public EmployeeService Service { get; set; }
        [TestMethod]
        public void GetEmployeeById()
        {
            var expectedFullName = "Nancy Davolio";
            var employee = Service.GetEmployeeById(1);
            var result = $"{employee.FirstName} {employee.LastName}";
            Assert.AreEqual(expectedFullName, result);
        }
        [TestMethod]
        public void AddEmployee()
        {
            var employee = new EmployeeDto
            {
                FirstName = "Can",
                LastName = "PERK",
                EMail = "can.perk@mail.com",
                City = "Ankara",
                Country = "Turkiye",
                BirthDate = new System.DateTime(1988, 2, 8),
                HireDate = DateTime.Now.AddDays(-45),
            };
            Service.AddEmployee(employee);
            UnitOfWork.Commit();
        }
        [TestMethod]
        public void GetAmericanEmployees()
        {
            var employees = Service.GetEmployeesByCountry("USA");
            Assert.IsTrue(employees.Any());
        }
        [TestMethod]
        public void GetEmployeesWhoHasNoManager()
        {
            var employees = Service.GetEmployeesWithoutManager();
            Assert.IsTrue(employees.Any());
        }
    }
}
