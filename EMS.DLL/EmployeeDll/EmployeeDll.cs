using EMS.DLL.Context;
using EMS.DLL.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.DLL.EmployeeDll
{
    public class EmployeeDll : IEmployeeDll
    {
        EmployeeDbContext _Context;
        public EmployeeDll(EmployeeDbContext Context)
        {
            this._Context = Context;
        }
        public Employee AddEmployees(Employee employees)
        {
            this._Context.Add(employees);
            _Context.SaveChanges();
            return employees;
        }

        public bool DeleteEmployees(Employee employees)
        {
            this._Context.Add(employees);
            _Context.SaveChanges();
            return true;
        }

        public bool EditEmployees(Employee employees)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeById(string Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetEmployees()
        {
            throw new NotImplementedException();
        }
    }
}
