using Northwind.Application.Categories;
using Northwind.Domain.Categories;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Northwind.Domain.Products;

namespace Northwind.UnitTests
{
    [TestClass]
    public class CategoryTest : UnitTestBase
    {
        public CategoryTest()
        {
            Service = new CategoryManager(UnitOfWork, _resolver.GetService<ICategoryRepository>(), _resolver.GetService<IProductRepository>());
        }
        public CategoryManager Service { get; set; }

        [TestMethod]
        public void CategoryHasProducts()
        {
            var category = Service.GetById(1);
            var result = Service.HasProducts(category);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CategoryProductsCheck()
        {
            var category = Service.GetById(1);
            var result = Service.GetProducts(category).ToList();
            Assert.IsTrue(result.Any() && result.First().Id == 1);
        }
    }
}
