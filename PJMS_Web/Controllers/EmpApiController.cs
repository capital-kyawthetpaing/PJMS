using Employee_BL;
using PJMS_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PJMS_Web.Controllers
{
    public class EmpApiController : ApiController
    {
        [UserAuthentication]
        [HttpPost]
        [ActionName("GetEmployee")]
        public string GetEmployee([FromBody] EmployeeModel employeeModel)
        {
            EmployeeBL employeeBL = new EmployeeBL();
            return employeeBL.GetEmployee(employeeModel);
        }
        public string InsertEmployee([FromBody] EmployeeModel employeeModel)
        {
            EmployeeBL employeeBL = new EmployeeBL();
            return employeeBL.InsertEmployee(employeeModel);
        }
    }
}
