using Northwind.Application.Employees;
using Northwind.Domain.Employees;
using Northwind.Framework.Domain;
using Northwind.Framework.Helpers;

namespace Northwind.Application.Services
{
    public class EmployeeService : IDomainService
    {
        private readonly IEmployeeRepository _repo;
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeService(IEmployeeRepository repo, IUnitOfWork unitOfWork)
        {
            _repo = repo;
            _unitOfWork = unitOfWork;
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

        public bool AddEmployee(EmployeeDto employee)
        {
            var entity = Employee.Create(employee.FirstName, employee.LastName, employee.EMail);
            entity.BirthDate = employee.BirthDate;
            entity.Country = employee.Country;
            entity.City = employee.City;
            entity.HireDate = employee.HireDate;
            _repo.Save(entity);
            return entity.Id > 0;
        }
    }
}
