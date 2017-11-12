using Northwind.Domain.Products;
using Northwind.Framework.Helpers;
using System;
using System.Collections.Generic;

namespace Northwind.Domain.Categories
{
    public interface ICategoryRepository : IRepository<Category, int>
    {
        
    }
}
