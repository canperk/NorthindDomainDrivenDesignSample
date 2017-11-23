using Northwind.Domain.Categories;
using Northwind.Framework;
using Northwind.Framework.Entity;
using Northwind.Domain.Suppliers;

namespace Northwind.Domain.Products
{
    public class Product : EntityBase, IEntityKey<long>
    {
        public long Id { get; protected set; }
        public string Name { get; protected set; }
        public decimal UnitPrice { get; protected set; }
        public double UnitsInStock { get; protected set; }
        public int CategoryId { get; protected set; }
        public int SupplierId { get; protected set; }

        public static Product Create(Category category, Supplier supplier, string name, decimal price, double stock)
        {
            var product = new Product();
            TypeCheck.IsNull(category);
            TypeCheck.IsUsableAsId(category.Id);
            TypeCheck.IsNull(supplier);
            TypeCheck.IsUsableAsId(supplier.Id);
            product.SetCategory(category.Id);
            product.SetName(name);
            product.SetPrice(price);
            product.SetStock(stock);
            product.SetSupplier(supplier.Id);
            return product;
        }

        public static Product CreateSimple(string name, decimal price, double stock)
        {
            var product = new Product();
            product.SetName(name);
            product.SetPrice(price);
            product.SetStock(stock);
            return product;
        }

        private void SetStock(double stock)
        {
            ProductPolicy.CheckStock(stock);
            //TODO: Fire event to notify supplier and sales employee
            UnitsInStock = stock;
        }
        private void SetPrice(decimal price)
        {
            ProductPolicy.CheckPrice(price);
            //TODO: Fire event to notify users for price change
            UnitPrice = price;
        }
        private void SetName(string name)
        {
            TypeCheck.IsNullOrEmpty(name);
            Name = name;
        }
        public void SetCategory(int id)
        {
            TypeCheck.IsUsableAsId(id);
            CategoryId = id;
        }
        public void SetSupplier(int id)
        {
            TypeCheck.IsUsableAsId(id);
            //TODO: Fire event to notify supplier on supplying new prouct
            SupplierId = id;
        }
        public void SetId(long id)
        {
            TypeCheck.IsUsableAsId(id);
            Id = id;
        }
    }
}
