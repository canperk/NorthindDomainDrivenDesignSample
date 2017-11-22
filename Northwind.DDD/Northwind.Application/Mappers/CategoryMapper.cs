using Northwind.Application.Categories;
using Northwind.Domain.Categories;

namespace Northwind.Application.Mappers
{
    public static class CategoryMapper
    {
        public static CategoryDto ToDto(this Category entity)
        {
            var dto = new CategoryDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Decription = entity.Description
            };
            return dto;
        }

        public static Category ToEntity(this CategoryDto dto)
        {
            var category = Category.Create(dto.Name, dto.Decription);
            category.SetId(dto.Id);
            return category;
        }
    }
}
