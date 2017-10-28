namespace Northwind.Framework.Helpers
{
    interface EventHandler<T> where T : DomainEvent
    {
        void Handle(T args);
    }
}
