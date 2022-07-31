using System.Collections.Generic;

namespace LinqDemo
{
    public class EmployeeRepository
    {
        public List<Employee> GetEmployee()
        {
            return new List<Employee>
            {
                new Employee(){Name="Mike", Id=2, Salary=5000},
                new Employee(){Name="Mary", Id=2, Salary=6000},
                new Employee(){Name="Dip", Id=2, Salary=7000},
                new Employee(){Name="Sayara", Id=2, Salary=8000},
            };
        }
    }
}
