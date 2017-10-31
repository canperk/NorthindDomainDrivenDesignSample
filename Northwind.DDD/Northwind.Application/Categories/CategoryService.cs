using System.Collections.Generic;
using Northwind.Domain.Categories;
using Northwind.Framework.Domain;
using Northwind.Framework.Helpers;
using Northwind.Application.Services;

namespace Northwind.Application.Categories
{
    public class CategoryService : ServiceBase, IDomainService
    {
        private readonly ICategoryRepository _repo;

        public CategoryService(ICategoryRepository repo)
        {
            _repo = repo;
        }
    }
}
