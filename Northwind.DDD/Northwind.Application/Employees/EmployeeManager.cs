using Northwind.Application.Employees;
using Northwind.Domain.Employees;
using Northwind.Framework.Domain;
using Northwind.Framework.Helpers;
using System.Collections.Generic;
using System.Linq;
using Northwind.Application.Mappers;

namespace Northwind.Application.Services
{
    public class EmployeeManager : IDomainService
    {
        private readonly IEmployeeRepository _repo;
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeManager(IEmployeeRepository repo, IUnitOfWork unitOfWork)
        {
            _repo = repo;
            _unitOfWork = unitOfWork;
        }

        public EmployeeDto GetEmployeeById(int id)
        {
            return _repo.FindById(id).ToDto();
        }

        public bool AddEmployee(EmployeeDto employee)
        {
            var entity = employee.ToEntity();
            _repo.Save(entity);
            return entity.Id > 0;
        }

        public IEnumerable<EmployeeDto> GetEmployeesByCountry(string country)
        {
            return _repo.GetEmployeesByCountry(country).Select(i => i.ToDto()).ToList();
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
            return _repo.Find(filter).Select(i => i.ToDto());
        }
    }
}
