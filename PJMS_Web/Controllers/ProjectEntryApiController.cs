using PJMS_Model;
using Project_BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PJMS_Web.Controllers
{
    public class ProjectEntryApiController : ApiController
    {
        [UserAuthentication]
        [HttpPost]
        [ActionName("InsertProject")]
         public string InsertProject([FromBody] ProjectModel projectModel)
        {
            ProjectBL projectBL = new ProjectBL();
            return projectBL.InsertProject(projectModel);
        }       
       
    }
}
