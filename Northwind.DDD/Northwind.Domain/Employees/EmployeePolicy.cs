namespace Northwind.Domain.Employees
{
    public class EmployeePolicy
    {
        public static void CheckNameRequirement(string name)
        {
            if (name.Length < 3)
                throw new NameIsTooShortException();
        }
        public static void CheckLastNameRequirement(string name)
        {
            if (name.Length < 2)
                throw new NameIsTooShortException();
        }
    }
}
