using Northwind.Domain.Orders;
using Northwind.Framework;
using Northwind.Framework.Domain;
using Northwind.Framework.Entity;
using System.Collections.Generic;

namespace Northwind.Domain.Customers
{
    public class Customer : EntityBase, IEntityKey<string>
    {
        public Customer()
        {
            _orders = new List<Order>();
        }
        private List<Order> _orders;
        public string Id { get; protected set; }

        public string CustomerId { get; protected set; }
        public string Title { get; protected set; }
        public string Contact { get; protected set; }
        public string ContactEMail { get; protected set; }

        public string City { get; set; }
        public string Country { get; set; }

        public virtual IReadOnlyCollection<Order> Orders => _orders.AsReadOnly();
        public void ChangeCustomerCode(string code)
        {
            //TODO: check whether customer code exists on database (it is unique)
            CustomerId = CustomerPolicy.CheckCustomerCode(TypeCheck.IsNullOrEmpty(code));
        }

        public void SetTitle(string title)
        {
            Title = TypeCheck.IsNullOrEmpty(title);
        }

        public void SetContact(string fullName, string email)
        {
            TypeCheck.IsNullOrEmpty(fullName);
            CommonPolicy.CheckMail(TypeCheck.IsNullOrEmpty(email));
            Contact = fullName;
            ContactEMail = email;

            //TODO: Fire an event to notify person about being customer as our customer
        }

        public void AddOrder(Order order)
        {
            _orders.Add(order);

            //TODO: Fire an event to manage other stuffs on creating and order for a customer
        }

        public void SetId(string id)
        {
            TypeCheck.IsNullOrEmpty(id);
            Id = id;
        }
    }
}
