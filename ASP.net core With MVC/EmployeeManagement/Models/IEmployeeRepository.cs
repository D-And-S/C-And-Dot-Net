using System.Collections.Generic;

namespace EmployeeManagement.Models
{
    public interface IEmployeeRepository
    {
        Employee UpdateEmployee(Employee employee);
        Employee DeleteEmployee(int id);
        IEnumerable<Employee> GetAllEmployee();
        Employee GetEmployee(int id);
        Employee AddNewEmployee(Employee employee);

    }
}
