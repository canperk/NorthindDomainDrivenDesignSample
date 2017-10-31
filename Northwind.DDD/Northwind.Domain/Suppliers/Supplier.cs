using Northwind.Domain.Products;
using Northwind.Framework;
using Northwind.Framework.Domain;
using Northwind.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Domain.Suppliers
{
    public class Supplier : EntityBase, IEntityKey<int>
    {
        public Supplier()
        {
            _products = new List<Product>();
        }
        private List<Product> _products;
        public int Id { get; protected set; }
        public string CompanyName { get; protected set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Manager { get; protected set; }
        public string Email { get; protected set; }
        public string Phone { get; protected set; }
        public string Fax { get; protected set; }

        public IReadOnlyCollection<Product> Products => _products.AsReadOnly();

        public static Supplier Create(string companyName, string manager, string email, string phone)
        {
            var supplier = new Supplier();
            TypeCheck.IsNullOrEmpty(companyName);
            TypeCheck.IsNullOrEmpty(manager);
            TypeCheck.IsNullOrEmpty(phone);
            supplier.CompanyName = companyName;
            supplier.Manager = manager;
            supplier.SetMail(email);
            supplier.Phone = phone;
            return supplier;
        }

        public void SetMail(string mail)
        {
            TypeCheck.IsNullOrEmpty(mail);
            CommonPolicy.CheckMail(mail);
            //TODO: Fire event to notify supplier about updated mail address
            Email = mail;
        }
    }
}
