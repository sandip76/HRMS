using AutoMapper;
using EMS.BLL.ModelBll;
using EMS.DLL.DataModels;
using EMS.DLL.EmployeeDll;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.BLL.EmployeeBll
{
    public class EmployeeBll : IEmployeeBll
    {
        IEmployeeDll _employeeDll;
        IMapper _mapper;
        public EmployeeBll(IEmployeeDll employeeDll, IMapper mapper)
        {
            _employeeDll = employeeDll;
            _mapper = mapper;
        }
        public EmployeeModelBll AddEmployees(EmployeeModelBll employees)
        {
            var empBll = _employeeDll.AddEmployees(_mapper.Map<Employee>(employees));
            return _mapper.Map<EmployeeModelBll>(empBll); 
        }

        public bool DeleteEmployees(EmployeeModelBll employees)
        {
            throw new NotImplementedException();
        }

        public bool EditEmployees(EmployeeModelBll employees)
        {
            throw new NotImplementedException();
        }

        public EmployeeModelBll GetEmployeeById(string Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeModelBll> GetEmployees()
        {
            throw new NotImplementedException();
        }
    }
}
