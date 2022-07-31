using System;
using System.Collections.Generic;

namespace Annonymouse_Function
{

    internal class Program
    {
        /*
            1. Annonymouse function which has no name 
            2. we use annonymouse function with delegates which is point to the function in c#
            3. without delegates we cannot create annonymouse function
            4. annonymouse method amader akta way provide kore jate amra separate method na define kore
               delegate toire korte pari
            5. tutorial Link:  https://www.youtube.com/watch?v=4trl43Ycksg 
         */

        static void Main(string[] args)
        {
            var listEmployees = new List<Employee>()
            {
                new Employee{ID = 1, Name = "Mark"},
                new Employee{ID = 2, Name = "John"},
                new Employee{ID = 3, Name = "Mary"},
            };

            // step 2
            //var data = new Predicate<Employee>(FindEmployee);

            //step 3
            //var employee =  listEmployees.Find(emp=> FindEmployee(emp));
            //Console.WriteLine(employee.Name);

            //Annonymouse function with delegate
            var employee = listEmployees.Find(delegate (Employee emp)
            {
                return emp.ID == 1;
            });
            Console.WriteLine(employee.Name);

            // we can do the above line with labda expression
            var employeWIthLamda = listEmployees.Find(x => x.ID == 2);
            Console.WriteLine(employeWIthLamda.Name);

            var employeeWithAnnonymouse = listEmployees.Find(delegate (Employee employee1)
            {
                return employee1.ID == 1;
            });
        }

        //step 1;
        //public static bool FindEmployee(Employee emp)
        //{
        //    return emp.ID == 1;
        //}
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
