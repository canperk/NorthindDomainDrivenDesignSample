using Northwind.Domain.Customers;
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
        public bool IsUrgent { get; protected set; }
        public DateTime? LastShipDate { get; protected set; }

        public static Order Create(Customer customer, bool isUrgent, DateTime? shipDate)
        {
            TypeCheck.IsNull(customer);
            TypeCheck.IsNullOrEmpty(customer.Id);
            var order = new Order() { CustomerId = customer.Id };
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
