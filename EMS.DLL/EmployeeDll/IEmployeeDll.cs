using EMS.DLL.DataModels;
using System.Collections.Generic;

namespace EMS.DLL.EmployeeDll
{
    public interface IEmployeeDll
    {
        Employee GetEmployeeById(string Id);
        IEnumerable<Employee> GetEmployees();
        Employee AddEmployees(Employee employees);
        bool EditEmployees(Employee employees);
        bool DeleteEmployees(Employee employees);
    }
}
