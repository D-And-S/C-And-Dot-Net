using System;

namespace OpenClosePrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee = new FullTimeEmployee(1, "John");
            var employee2 = new PartTimeEmployee(2, "Json");

            Console.WriteLine("Empoloyee : {0} Bhonus: {1}", employee.Name, employee.CalculateBonus(10000));
            Console.WriteLine("Empoloyee : {0} Bhonus: {1}", employee2.Name, employee2.CalculateBonus(10000));
        }
    }
}
