using Employee_BL;
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

    public class UpdateApiController : ApiController
    {
        [ActionName("UpdateProject")]
        public string UpdateProject([FromBody] ProjectModel projectModel)
        {
            ProjectBL projectBL = new ProjectBL();
            return projectBL.UpdateProject(projectModel);
        }       
    }
}
