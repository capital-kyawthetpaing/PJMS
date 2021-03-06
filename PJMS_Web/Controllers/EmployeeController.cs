﻿using PJMS_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PJMS_Web.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Test
        public ActionResult EmployeeList()
        {
            return View();

        }
        public ActionResult EmployeeEntry(EmployeeModel eModel)
        {
            if (string.IsNullOrWhiteSpace(eModel.Mode))
                eModel.Mode = "New";
            return View(eModel);
     
        }
        public ActionResult Employee_Save(EmployeeModel employeeModel)
        {
            return RedirectToAction("EmployeeList");
        }
    }
}