using System;
using System.Collections.Generic;

namespace Delegates2
{
    class Program
    {
        static void Main(string[] args)
        {
            var empList = new List<Employee>();
            var employee = new Employee();
            var isPromotable = new IsPromotable(PromoteBySalary);

            empList.Add(new Employee() { Id=101, Name="Mary",Salary=5000, Experience=5});
            empList.Add(new Employee() { Id=101, Name="Mike",Salary=4000, Experience=4});
            empList.Add(new Employee() { Id=101, Name="John",Salary=6000, Experience=6});
            empList.Add(new Employee() { Id=101, Name="Todd",Salary=3000, Experience=3});

            employee.PromoteEmployee(empList,isPromotable);
            
        }

        public static bool PromoteByExpericne(Employee emp)
        {
            if (emp.Experience >= 5)
                return true;
            else
                return false;
        }

        public static bool PromoteBySalary(Employee emp)
        {
            if (emp.Salary >= 6000)
                return true;
            else
                return false;
        }

    }

    delegate bool IsPromotable(Employee employee);
    class Employee
    {        
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public void PromoteEmployee(List<Employee> employeeList, IsPromotable isPromotable)
        {
            foreach (var employee in employeeList)
            {
                if (isPromotable(employee)) 
                {
                    Console.WriteLine(employee.Name + " promoted");
                }
            }
        }


    }
}
