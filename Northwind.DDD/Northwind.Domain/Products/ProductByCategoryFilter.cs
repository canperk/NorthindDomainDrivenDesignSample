using Northwind.Domain.Categories;
using Northwind.Framework.Helpers.Filters;
using System;
using System.Linq.Expressions;

namespace Northwind.Domain.Products
{
    public class ProductByCategoryFilter : FilterBase<Product>
    {
        private long _categoryId;
        public ProductByCategoryFilter(int categoryId)
        {
            _categoryId = categoryId;
        }
        public override Expression<Func<Product, bool>> FilterExpression => i => i.CategoryId == _categoryId;
    }
}
