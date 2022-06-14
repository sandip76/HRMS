using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.BLL.ModelBll
{
    public class EmployeeModelBll
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmailId { get; set; }
        public int MobileNo { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string MaritalStatus { get; set; }
    }
}
