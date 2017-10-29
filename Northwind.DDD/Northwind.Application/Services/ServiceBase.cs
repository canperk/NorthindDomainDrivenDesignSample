using Northwind.Framework.Helpers;

namespace Northwind.Application.Services
{
    public abstract class ServiceBase
    {
        public ServiceBase()
        {
            //TODO injection from .net core IoC container
        }
        public ServiceBase(IUnitOfWork unitOfWork) : this()
        {
            UnitOfWork = unitOfWork;
        }
        public IUnitOfWork UnitOfWork { get; private set; }
    }
}
