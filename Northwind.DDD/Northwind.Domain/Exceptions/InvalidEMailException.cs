namespace Northwind.Domain
{
    public class InvalidEMailException : OperationalException
    {
        public InvalidEMailException()
        {
            Type = ExceptionType.InvalidMailAddress;
        }
    }
}
