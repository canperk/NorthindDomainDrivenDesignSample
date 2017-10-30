using Northwind.Framework.Entity;

namespace Northwind.Domain.Products
{
    public class Product : EntityBase, IEntityKey<long>
    {
        public long Id { get; protected set; }
        public string Name { get; protected set; }
        public decimal UnitPrice { get; protected set; }
        public int CategoryId { get; protected set; }
    }
}
