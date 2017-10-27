namespace Northwind.Domain.Employees
{
    public class EmployeePolicy 
    {
       public void CheckNameRequirement(string name)
        {
            if (name.Length < 3)
                throw new NameIsTooShortException();
        }
    }
}
