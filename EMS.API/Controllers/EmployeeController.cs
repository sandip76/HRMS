using EMS.BLL.EmployeeBll;
using EMS.BLL.ModelBll;
using Microsoft.AspNetCore.Mvc;

namespace EMS.API.Controllers
{
    public class EmployeeController : Controller
    {
        
       private readonly IEmployeeBll _employeeBll;
        public EmployeeController(IEmployeeBll employeeBll)
        {
            this._employeeBll = employeeBll;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(_employeeBll.GetEmployees());
        }
        [HttpGet("{id}")]
        public IActionResult GetEmployee(int id)
        {
           return Ok();
        }
        public IActionResult AddEmployee(EmployeeModelBll employee)
        {
            var emp = _employeeBll.AddEmployees(employee);
            return Ok();
            // return_employeeBll.Add(employee);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, EmployeeModelBll employee)
        {
            return Ok();
            //var res = Repository.GetById(id);
            //Repository.Modify(employee);
            //Repository.Save();
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //Repository.Remove(id);
            //Repository.Save();
        }
    }
}
