using Northwind.Application.Employees;
using Northwind.Domain.Employees;

namespace Northwind.Application.Mappers
{
    public static class EmployeeMapper
    {
        public static EmployeeDto ToDto(this Employee entity)
        {
            var dto = new EmployeeDto
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                EMail = entity.EMail,
                Country = entity.Country,
                City = entity.City,
                HireDate = entity.HireDate,
                ManagerId = entity.ManagerId,
                BirthDate = entity.BirthDate
            };
            return dto;
        }

        public static Employee ToEntity(this EmployeeDto dto)
        {
            var employee = Employee.Create(dto.FirstName, dto.LastName,dto.EMail);
            employee.SetId(dto.Id);
            employee.BirthDate = dto.BirthDate;
            employee.Country = dto.Country;
            employee.City = dto.City;
            employee.HireDate = dto.HireDate;
            return employee;
        }
    }
}
