namespace Northwind.Framework.Entity
{
    public interface IEntityKey<TKey>
    {
        TKey Id { get; }
    }
}
