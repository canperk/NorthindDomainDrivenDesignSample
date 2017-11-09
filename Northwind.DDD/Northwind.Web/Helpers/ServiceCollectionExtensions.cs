using Microsoft.Extensions.DependencyInjection;
using Northwind.Application.Employees;
using Northwind.Domain.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.Web.Helpers
{
    public static class ServiceCollectionExtensions
    {
        public static void UseNorthwindDomainDriven(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        }
    }
}
