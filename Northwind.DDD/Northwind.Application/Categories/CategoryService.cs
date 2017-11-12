using System.Collections.Generic;
using Northwind.Domain.Categories;
using Northwind.Framework.Domain;
using Northwind.Framework.Helpers;
using Northwind.Application.Services;
using System;

namespace Northwind.Application.Categories
{
    public class CategoryService : IDomainService
    {
        private readonly ICategoryRepository _repo;
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(ICategoryRepository repo, IUnitOfWork unitOfWork)
        {
            _repo = repo;
            _unitOfWork = unitOfWork;
        }

        public bool HasProducts(Category category)
        {
            return true;
        }

        public Category GetById(int id)
        {
            return _repo.FindById(id);
        }
    }
}
