using System;
using System.Collections.Generic;

namespace DelegatesDemo
{
    public delegate void ApplyBrightNessDelegate(string message);
    public delegate bool GetEmployeeNameById(Employee emp);

    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                -- What is Delegate: A delegate point to type safe function

                -- why should we use delegate ? to get the flexibility of a function. 

                   -- it just point to a function we need just define the function signature
                   -- but the implementation can be diffrent by people              

                -- upore amra akta delegate define korechi jekhane akta signature dea ache 
                -- now ai deleget akhon use kora jabe je kono function ke point kore just signature match hote hobe

                -- How to use Delegate ? to use delegate we need to create an instance of a delegate
                -- and pass a function in the constructor of the delegate 
                -- type safe means return type  
            */

            var delg = new ApplyBrightNessDelegate(ApplyBrightNess);
            delg("Hello From Delegate");


            var employeeList = new List<Employee>()
            {
                new Employee{Id = 1, Name = "MH"},
                new Employee{Id = 2, Name = "Sayara"},
                new Employee{Id = 3, Name = "Ratul"}
            };


            var employeDelegate = new GetEmployeeNameById(HasEmployee);

            var emp = employeeList.Find(emp => employeDelegate(emp));
            Console.WriteLine(emp.Name);

        }

        public static bool HasEmployee(Employee emp)
        {
            return emp.Id == 1;
        }

        public static void ApplyBrightNess(string message)
        {
            Console.WriteLine(message);
        }

    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
