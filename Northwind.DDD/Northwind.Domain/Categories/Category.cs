using Northwind.Domain.Products;
using Northwind.Framework;
using Northwind.Framework.Entity;
using System.Collections.Generic;

namespace Northwind.Domain.Categories
{
    public class Category : EntityBase, IEntityKey<int>
    {
        public Category()
        {
            _products = new List<Product>();
        }
        private List<Product> _products;
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public string Description { get; set; }

        public void SetName(string name)
        {
            TypeCheck.IsNullOrEmpty(name);
            //Check duplicated name from database --> domain rule
            Name = name;
        }
        public IReadOnlyCollection<Product> Products => _products.AsReadOnly();

        public static Category Create(string name)
        {
            var category = new Category();
            return category;
        }
    }
}
