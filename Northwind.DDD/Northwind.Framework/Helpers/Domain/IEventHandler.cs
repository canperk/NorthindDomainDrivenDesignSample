namespace Northwind.Framework.Helpers
{
    interface IEventHandler<T> where T : DomainEvent
    {
        void Handle(T args);
    }
}
