using Northwind.Application.Employees;
using Northwind.Domain.Employees;
using Northwind.Framework.Domain;

namespace Northwind.Application.Services
{
    public class EmployeeService : ServiceBase, IDomainService
    {
        private readonly IEmployeeRepository _repo;

        public EmployeeService(IEmployeeRepository repo)
        {
            _repo = repo;
        }

        public EmployeeDto GetEmployeeById(int id)
        {
            var employee = _repo.FindById(id);
            var result = new EmployeeDto
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                BirthDate = employee.BirthDate,
                City = employee.City,
                Country = employee.Country,
                EMail = employee.EMail,
                HireDate = employee.HireDate,
                ManagerId = employee.ManagerId
            };
            return result;
        }
    }
}
