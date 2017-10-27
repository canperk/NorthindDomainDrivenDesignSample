using Northwind.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Domain.Employees
{
    public class Employee
    {
        public string FirstName { get; protected set; } 
        public string LastName { get; protected set; }
        public DateTime? HireDate { get; set; }
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
