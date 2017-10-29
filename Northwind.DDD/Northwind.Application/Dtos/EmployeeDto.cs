using System;

namespace Northwind.Application.Dtos
{
    public class EmployeeDto
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? BirthDate { get; set; }
        public string EMail { get; set; }
        public long ManagerId { get; set; }
    }
}
