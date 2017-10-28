namespace Northwind.Framework.Domain
{
    public class InvalidEMailException : OperationalException
    {
        public InvalidEMailException()
        {
            Type = ExceptionType.InvalidMailAddress;
        }
    }
}
