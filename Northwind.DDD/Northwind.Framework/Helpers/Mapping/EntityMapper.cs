namespace Northwind.Framework.Helpers
{
    public interface IEntityMapper<TEntity, TDto>
    {
        TEntity ToEntity(TDto dto);
        TDto ToDto(TEntity entity);
    }
}
