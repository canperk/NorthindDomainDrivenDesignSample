using Northwind.Domain.Employees;
using System;

namespace Northwind.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var employee = new Employee().SetName("Can").SetLastName("PERK");
        }
    }
}
