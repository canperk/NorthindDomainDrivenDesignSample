using Northwind.Domain.Employees;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Northwind.Framework.Helpers;
using System.Linq;
using Northwind.Framework.Domain.Exceptions;
using Northwind.Framework;

namespace Northwind.Application.Employees
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IUnitOfWork _unitOfwork;
        public EmployeeRepository(IUnitOfWork unitOfwork)
        {
            _unitOfwork = unitOfwork;
        }
        public DbSet<Employee> Repository => _unitOfwork.GetDbSet<Employee>();

        public IEnumerable<Employee> Find(IFilter<Employee> filter)
        {
            return Repository.Where(filter.FilterExpression).ToList();
        }

        public Employee FindById(int id)
        {
            var employee = Repository.FirstOrDefault(i => i.Id == id);
            if (employee == null)
            {
                throw new NotFoundByIdException();
            }
            return employee;
        }

        public Employee FindSingle(IFilter<Employee> spec)
        {
            return Repository.Where(spec.FilterExpression).SingleOrDefault();
        }

        public IEnumerable<Employee> GetEmployeesByCountry(string countryName)
        {
            return Repository.Where(i => i.Country == countryName).ToList();
        }

        public Employee GetManager(int employeeId)
        {
            var employee = FindById(employeeId);
            if (TypeCheck.IsUsableAsId(employee.ManagerId))
            {
                var manager = FindById(employee.ManagerId.Value);
                return manager;
            }
            return null;
        }

        public void Remove(Employee entity)
        {
            Repository.Remove(entity);
        }

        public void Save(Employee entity)
        {
            Repository.Add(entity);
        }
    }
}
