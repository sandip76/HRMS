using EMS.BLL.ModelBll;
using System.Collections.Generic;

namespace EMS.BLL.EmployeeBll
{
    public interface IEmployeeBll
    {
        EmployeeModelBll GetEmployeeById(string Id);
        IEnumerable<EmployeeModelBll> GetEmployees();
        EmployeeModelBll AddEmployees(EmployeeModelBll employees);
        bool EditEmployees(EmployeeModelBll employees);
        bool DeleteEmployees(EmployeeModelBll employees);
    }
}
