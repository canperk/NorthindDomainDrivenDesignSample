using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Application.Categories;
using Northwind.Application.Database;
using Northwind.Application.Employees;
using Northwind.Application.Products;
using Northwind.Application.Services;
using Northwind.Domain.Categories;
using Northwind.Domain.Employees;
using Northwind.Domain.Products;
using Northwind.Framework.Helpers;

namespace Northwind.Application
{
    public static class ExtensionRegistery
    {
        public static void AddNorthwind(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<DbContext, NorthwindDbContext>();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddScoped<IEmployeeRepository, EmployeeRepository>();
            serviceCollection.AddScoped<ICategoryRepository, CategoryRepository>();
            serviceCollection.AddScoped<IProductRepository, ProductRepository>();
            serviceCollection.AddScoped<EmployeeManager, EmployeeManager>();
        }
    }
}
