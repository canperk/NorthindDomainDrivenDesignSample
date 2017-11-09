namespace Northwind.Framework.Domain
{
    public enum ExceptionType
    {
        NotSet = 0,
        NameIsTooShort = 1,
        InvalidCharacter = 2,
        EmptyValue = 3,
        InvalidMailAddress = 4,
        InvalidCustomerCode = 5,
        InvalidId = 6,
        InvalidPrice = 7,
        InvalidStock = 8,
        InvalidOrderPriceException = 9,
        InvalidOrderQuantityException = 10,
        EntityNotFoundById = 11
    }
}
