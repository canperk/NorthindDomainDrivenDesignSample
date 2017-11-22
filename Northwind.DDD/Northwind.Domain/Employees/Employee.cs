using Northwind.Framework;
using Northwind.Framework.Domain;
using Northwind.Framework.Entity;
using System;

namespace Northwind.Domain.Employees
{
    public class Employee : EntityBase, IEntityKey<int>
    {
        public int Id { get; protected set; }
        public string FirstName { get; protected set; } 
        public string LastName { get; protected set; }

        public DateTime? HireDate { get; set; }
        public DateTime? BirthDate { get; set; }
        public string EMail { get; protected set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int? ManagerId { get; protected set; }
        public static Employee Create(string firstname, string lastname, string email)
        {
            var employee = new Employee();
            employee.SetName(firstname);
            employee.SetLastName(lastname);
            employee.SetEMail(email);
            employee.Created = DateTime.Now;
            employee.Modified = DateTime.Now;
            return employee;
        }
        public void SetName(string name)
        {
            EmployeePolicy.CheckNameRequirement(name);
            FirstName = TypeCheck.IsNullOrEmpty(name);
        }
        public void SetLastName(string lastname)
        {
            EmployeePolicy.CheckLastNameRequirement(lastname);
            LastName = TypeCheck.IsNullOrEmpty(lastname); 
        }

        public void SetEMail(string email)
        {
            CommonPolicy.CheckMail(TypeCheck.IsNullOrEmpty(email));
            EMail = email;
        }

        public void SetId(int id)
        {
            TypeCheck.IsUsableAsId(id);
            Id = id;
        }
    }
}
