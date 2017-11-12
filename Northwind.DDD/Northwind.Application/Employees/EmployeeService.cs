using System;
using Northwind.Application.Employees;
using Northwind.Domain.Employees;
using Northwind.Framework.Domain;
using Northwind.Framework.Helpers;
using System.Collections.Generic;
using System.Linq;

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

        public IEnumerable<EmployeeDto> GetEmployeesByCountry(string country)
        {
            return _repo.GetEmployeesByCountry(country).Select(i => new EmployeeDto
            {
                Id = i.Id,
                FirstName = i.FirstName,
                LastName = i.LastName,
                BirthDate = i.BirthDate,
                City = i.City,
                Country = i.Country,
                EMail = i.EMail,
                HireDate = i.HireDate,
                ManagerId = i.ManagerId
            }).ToList();
        }

        public bool UserHasManager(int id)
        {
            var employee = _repo.FindById(id);
            var filter = new HasManagerFilter();
            return filter.IsFilteredBy(employee);
        }

        public IEnumerable<EmployeeDto> GetEmployeesWithoutManager()
        {
            var filter = new HasNoManagerFilter();
            return _repo.Find(filter).Select(i => new EmployeeDto
            {
                Id = i.Id,
                FirstName = i.FirstName,
                LastName = i.LastName,
                BirthDate = i.BirthDate,
                City = i.City,
                Country = i.Country,
                EMail = i.EMail,
                HireDate = i.HireDate,
                ManagerId = i.ManagerId
            });
        }
    }
}
