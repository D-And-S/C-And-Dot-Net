using System;
using System.Collections.Generic;

namespace AnnonymouseMethod
{
    class Program
    {
        // we use annonymouse functio to point delegete with less code 
        static void Main(string[] args)
        {
            var listEmploye = new List<Employee>()
            {
                new Employee{ID = 101, Name = "Mark"},
                new Employee{ID = 102, Name = "John"},
                new Employee{ID = 103, Name = "Mary"},
            };

            //var employeePredicate = new Predicate<Employee>(FindEmployee);

            var employee = listEmploye.Find(emp =>
            {
                return emp.ID == 103;
            });
            Console.WriteLine("ID = {0}, Name = {1}", employee.ID, employee.Name);

        }

        //public static bool FindEmployee(Employee emp)
        //{
        //    return emp.ID == 102;
        //}
    }


    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
