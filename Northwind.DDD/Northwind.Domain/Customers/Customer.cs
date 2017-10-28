using Northwind.Framework;
using Northwind.Framework.Entity;

namespace Northwind.Domain.Customers
{
    public class Customer : EntityBase, IEntityKey<string>
    {
        public string Id { get; protected set; }
        
        public string CustomerId { get; protected set; }
        public string Title { get; protected set; }
        public string Contact { get; protected set; }
        public string ContactEMail { get; protected set; }

        public string City { get; set; }
        public string Country { get; set; }

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
    }
}
