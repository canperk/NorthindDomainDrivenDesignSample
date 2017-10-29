using Northwind.Framework.Helpers;

namespace Northwind.Domain.Customers
{
    public interface ICustomerRepository : IRepository<Customer, string>
    {
        Customer GetContactByMail(string email);
    }
}
