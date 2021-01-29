﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Employee_BL;
using PJMS_Model;

namespace PJMS_Web.Controllers
{
    public class EmployeeListApiController : ApiController
    {
        [UserAuthentication]
        [HttpPost]
        [ActionName("GetEmployee")]
        public IHttpActionResult GetEmployee([FromBody] EmployeeModel employeeModel)
        {
            EmployeeBL employeeBL = new EmployeeBL();
            return Ok(employeeBL.GetEmployee(employeeModel));
        }
    }
}