using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Application.Database;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Northwind.Application;
using Northwind.Framework.Domain.Exceptions;

namespace Northwind.Web
{
    public class Startup
    {
        public Startup()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json");
            Configuration = builder.Build();
        }
        public IConfigurationRoot Configuration { get; set; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(
                config => {
                    config.Filters.Add(typeof(NorthwindExceptionHandler));
                }
            );
            //TODO: Generic injector --> https://horfin.visualstudio.com/Horfin/_versionControl?path=%24%2FHorfin%2FHorfin.Data%2FServiceCollectionExtensions.cs&_a=contents
            services.AddDbContext<NorthwindDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddNorthwind();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
