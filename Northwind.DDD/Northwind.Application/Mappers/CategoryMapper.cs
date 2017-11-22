using Northwind.Application.Categories;
using Northwind.Domain.Categories;
using Northwind.Framework.Helpers;

namespace Northwind.Application.Mappers
{
    public class CategoryMapper : SingleObject<CategoryMapper>, IEntityMapper<Category, CategoryDto>
    {
        public CategoryDto ToDto(Category entity)
        {
            var dto = new CategoryDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Decription = entity.Description
            };
            return dto;
        }

        public Category ToEntity(CategoryDto dto)
        {
            var category = Category.Create(dto.Name, dto.Decription);
            category.SetId(dto.Id);
            return category;
        }
    }
}
