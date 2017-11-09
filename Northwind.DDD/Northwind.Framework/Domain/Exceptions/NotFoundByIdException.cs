namespace Northwind.Framework.Domain.Exceptions
{
    public class NotFoundByIdException : OperationalException
    {
        public NotFoundByIdException()
        {
            Type = ExceptionType.EntityNotFoundById;
        }
    }
}
