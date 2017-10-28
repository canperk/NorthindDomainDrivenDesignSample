using Northwind.Framework;
using Northwind.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Domain.Employees
{
    public class Employee : EntityBase, IEntityKey<long>
    {
        public long Id { get; protected set; }
        public string FirstName { get; protected set; } 
        public string LastName { get; protected set; }

        public DateTime? HireDate { get; set; }
        public DateTime? BirtDate { get; set; }
        public string EMail { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public Employee SetName(string name)
        {
            TypeCheck.IsNullOrEmpty(name);
            FirstName = name;
            return this;
        }
        public Employee SetLastName(string name)
        {
            TypeCheck.IsNullOrEmpty(name);
            LastName = name;
            return this;
        }
    }
}
