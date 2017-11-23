using Northwind.Application.Products;
using Northwind.Domain.Products;

namespace Northwind.Application.Mappers
{
    public static class ProductMapper
    {
        public static ProductDto ToDto(this Product entity)
        {
            var dto = new ProductDto
            {
                Id = entity.Id,
                ProductName = entity.Name,
                Price = entity.UnitPrice,
                UnitsInStock = entity.UnitsInStock,
                CategoryId = entity.CategoryId,
                SupplierId = entity.SupplierId
            };
            return dto;
        }

        public static Product ToEntity(this ProductDto dto)
        {
            var product = Product.CreateSimple(dto.ProductName, dto.Price, dto.UnitsInStock);
            product.SetId(dto.Id);
            return product;
        }
    }
}
