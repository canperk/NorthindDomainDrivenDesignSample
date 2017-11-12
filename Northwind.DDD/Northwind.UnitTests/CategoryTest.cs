using Northwind.Application.Categories;
using Northwind.Domain.Categories;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Northwind.UnitTests
{
    public class CategoryTest : UnitTestBase
    {
        public CategoryTest()
        {
            Service = new CategoryService(_resolver.GetService<ICategoryRepository>(), UnitOfWork);
        }
        public CategoryService Service { get; set; }

        [TestMethod]
        public void CategoryHasProducts()
        {
            var category = Service.GetById(1);
            var result = Service.HasProducts(category);
        }
    }
}
