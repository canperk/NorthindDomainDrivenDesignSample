using Northwind.Framework;
using Northwind.Framework.Entity;

namespace Northwind.Domain.Customers
{
    public class Customer : EntityBase, IEntityKey<string>
    {
        public string Id { get; protected set; }
        public string CustomerId { get; protected set; }
        public string EMail { get; protected set; }

        public string City { get; set; }
        public string Country { get; set; }

        public void ChangeCustomerCode(string code)
        {
            TypeCheck.IsNullOrEmpty(code);
            CustomerId = code;
        }

        public void ChangeEMail(string email)
        {
            TypeCheck.IsNullOrEmpty(email);
            //TODO: check whether email parameter is an email or not with policy

            EMail = email;
        }
    }
}
