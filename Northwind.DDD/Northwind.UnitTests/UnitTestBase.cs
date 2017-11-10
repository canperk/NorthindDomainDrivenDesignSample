using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Application;
using Northwind.Application.Database;
using Northwind.Application.Employees;
using Northwind.Domain.Employees;
using Northwind.Framework.Helpers;
using System;
using System.IO;

namespace Northwind.UnitTests
{
    public abstract class UnitTestBase
    {
        protected readonly IServiceProvider _resolver;
        protected readonly IServiceCollection _services;
        public UnitTestBase()
        {
            _services = new ServiceCollection();

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appSettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            var configuration = builder.Build();
            _services.AddDbContext<NorthwindDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            _services.AddNorthwind();
            _resolver = _services.BuildServiceProvider();
            UnitOfWork = _resolver.GetService<IUnitOfWork>();
        }
        public IUnitOfWork UnitOfWork { get; set; }
    }
}