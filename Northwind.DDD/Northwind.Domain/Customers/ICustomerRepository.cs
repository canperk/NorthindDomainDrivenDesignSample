using Northwind.Framework.Helpers;

namespace Northwind.Domain.Customers
{
    public interface ICustomerRepository : IEmployeeRepository<Customer, string>
    {
        Customer GetContactByMail(string email);
    }
}
