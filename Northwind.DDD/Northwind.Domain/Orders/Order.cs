using Northwind.Domain.Customers;
using Northwind.Domain.Employees;
using Northwind.Framework;
using Northwind.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Domain.Orders
{
    public class Order : EntityBase, IEntityKey<long>
    {
        public long Id { get; protected set; }
        public string CustomerId { get; protected set; }
        public int EmployeeId { get; protected set; }
        public bool IsUrgent { get; protected set; }
        public DateTime? LastShipDate { get; protected set; }

        public static Order Create(Customer customer, Employee employee, bool isUrgent, DateTime? shipDate)
        {
            TypeCheck.IsNull(customer);
            TypeCheck.IsNullOrEmpty(customer.Id);
            TypeCheck.IsNull(employee);
            TypeCheck.IsUsableAsId(employee.Id);
            var order = new Order() { CustomerId = customer.Id, EmployeeId = employee.Id };
            if (isUrgent)
            {
                order.SetAsUrgent(shipDate);
            }
            return order;
        }

        public void SetAsUrgent(DateTime? shipDate = null)
        {
            IsUrgent = true;
            if (!shipDate.HasValue)
            {
                LastShipDate = DateTime.Now.AddHours(1);//Domain rule
            }
            else
            {
                LastShipDate = DateTime.Now.AddDays(1);//Domain rule
            }

            //TODO: Fire event to notify employee on sending this urgent order
        }
    }
}
