using System.Collections.Generic;
using System.Linq;


namespace EmployeeManagement.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly List<Employee> _employeeList;
        public EmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){Id=1, Name="Marry", Department= Dept.HR, Email="Marry@Gmail.com"},
                new Employee(){Id = 2, Name ="John", Department = Dept.IT, Email="John@gmail.com"},
                new Employee(){Id = 3, Name ="Sam", Department = Dept.Account, Email="Sam@gmail.com"},
            };         
        }
        public Employee AddNewEmployee(Employee employee)
        {
            employee.Id = _employeeList.Max(x => x.Id) + 1;
            _employeeList.Add(employee);
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e=>e.Id == id);
        }

        public Employee DeleteEmployee(int id)
        {
            var employee = _employeeList.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                _employeeList.Remove(employee);
            }
            return employee;
        }

        public Employee UpdateEmployee(Employee emp)
        {
            var employee = _employeeList.FirstOrDefault(e => e.Id == emp.Id);
            if (employee != null)
            {
                employee.Name = emp.Name;
                employee.Email = emp.Email;
                employee.Department = emp.Department;
            }
            return employee;
        }
    }
}
