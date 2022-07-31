using System;
using System.Linq;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new EmployeeRepository().GetEmployee();

            // LINQ Query Operators
            var minSalaryEmployee = from e in employee
                                    where e.Salary <= 5000
                                    orderby e.Salary
                                    select e;

            // LINQ Extension Methods
            var higestSalary = employee
                               .Where(e => e.Salary > 7000)
                               .OrderByDescending(e => e.Salary)
                               .ToList();

            //foreach (var item in higestSalary)
            //    Console.WriteLine(item.Name);


            // if i want to return single object 
            var singleEmployee = employee.SingleOrDefault(e=>e.Name == "Marysdf");

            if(singleEmployee != null)
            {
                Console.WriteLine(singleEmployee.Name);
            }

            var skipTake = employee.Skip(2).Take(3);

        }
    }
}
