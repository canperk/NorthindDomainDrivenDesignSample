using Northwind.Framework.Helpers;

namespace Northwind.Domain.Products
{
    public interface IProductRepository : IRepository<Product, long>
    {
    }
}
