using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Employee_BL;
using PJMS_Model;
using System.Web.Http;
using Project_BL;

namespace PJMS_Web.Controllers
{
    public class EmployeeEntryApiController : ApiController
    {
        public IHttpActionResult InsertEmployee([FromBody] EmployeeModel employeeModel)
        {
            EmployeeBL employeeBL = new EmployeeBL();
            return Ok(employeeBL.InsertEmployee(employeeModel));
        }

    }
}
