﻿using System;
using Northwind.Domain.Categories;
using Northwind.Framework;
using Northwind.Framework.Entity;

namespace Northwind.Domain.Products
{
    public class Product : EntityBase, IEntityKey<long>
    {
        public long Id { get; protected set; }
        public string Name { get; protected set; }
        public decimal UnitPrice { get; protected set; }
        public double UnitsInStock { get; protected set; }
        public int CategoryId { get; protected set; }

        public static Product Create(Category category, string name, decimal price, double stock)
        {
            var product = new Product();
            TypeCheck.IsNull(category);
            TypeCheck.IsUsableAsId(category.Id);
            product.SetCategory(category.Id);
            product.SetName(name);
            product.SetPrice(price);
            return product;
        }

        private void SetPrice(decimal price)
        {
            ProductPolicy.CheckPrice(price);
            UnitPrice = price;
        }

        private void SetName(string name)
        {
            TypeCheck.IsNullOrEmpty(name);
            Name = name;
        }


        public void SetCategory(int id)
        {
            TypeCheck.IsUsableAsId(id);
            CategoryId = id;
        }


    }
}