using Northwind.Domain.Orders;
using Northwind.Domain.Products;
using Northwind.Framework;
using Northwind.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Domain.OrderDetails
{
    public class OrderDetail : EntityBase, IEntityKey<long>
    {
        public long Id { get; protected set; }
        public long OrderId { get; protected set; }
        public long ProductId { get; protected set; }
        public double Quantity { get; protected set; }
        public double Price { get; protected set; }
        public double Discount { get; protected set; }

        public static OrderDetail Create(Product product, Order order, double price, double quantity, double discount = 0)
        {
            var orderDetail = new OrderDetail();
            TypeCheck.IsNull(product);
            TypeCheck.IsUsableAsId(product.Id);
            TypeCheck.IsNull(product);
            TypeCheck.IsUsableAsId(order.Id);
            OrderDetailPolicy.CheckPrice(price);
            OrderDetailPolicy.CheckQuantity(quantity);
            orderDetail.SetProduct(product.Id);
            orderDetail.SetOrder(order.Id);
            orderDetail.SetPrice(price);
            orderDetail.SetQuantity(quantity);
            if(discount > 0)
            {
                orderDetail.SetDiscount(discount);
            }
            return orderDetail;
        }

        private void SetDiscount(double discount)
        {
            throw new NotImplementedException();
        }

        private void SetQuantity(double quantity)
        {
            throw new NotImplementedException();
        }

        private void SetPrice(double price)
        {
            throw new NotImplementedException();
        }

        private void SetOrder(long id)
        {
            throw new NotImplementedException();
        }

        private void SetProduct(long id)
        {
            throw new NotImplementedException();
        }

        public void SetId(long id)
        {
            TypeCheck.IsUsableAsId(id);
            Id = id;
        }
    }
}
