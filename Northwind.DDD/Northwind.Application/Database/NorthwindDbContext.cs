using Microsoft.EntityFrameworkCore;
using Northwind.Domain.Categories;
using Northwind.Domain.Customers;
using Northwind.Domain.Employees;
using Northwind.Domain.OrderDetails;
using Northwind.Domain.Orders;
using Northwind.Domain.Products;
using Northwind.Domain.Suppliers;

namespace Northwind.Application.Database
{
    public class NorthwindDbContext : DbContext
    {
        public NorthwindDbContext(DbContextOptions<NorthwindDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>(e => {
                e.HasKey(x => x.Id);
                e.Property(x => x.EmployeeId).IsRequired();
                e.HasOne<Employee>()
                    .WithMany()
                    .HasForeignKey(x => x.EmployeeId);
            });

            modelBuilder.Entity<OrderDetail>(e => {
                e.HasKey(x => x.Id);
                e.Property(x => x.OrderId).IsRequired();
                e.Property(x => x.ProductId).IsRequired();
                e.HasOne<Order>()
                    .WithMany()
                    .HasForeignKey(x => x.OrderId);
                e.HasOne<Product>()
                    .WithMany()
                    .HasForeignKey(x => x.ProductId);
            });

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
