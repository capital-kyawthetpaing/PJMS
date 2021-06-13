using System.Web.Http;
using ProjectType_BL;
using PJMS_Model;

namespace PJMS_Web.Controllers
{
    public class ProjectTypeApiController : ApiController
    {
        [UserAuthentication]
        [HttpPost]
        [ActionName("GetProjectType")]
        public IHttpActionResult GetProjectType([FromBody] ProjectTypeModel projectTypeModel)
        {
            ProjectTypeBL projectTypeBL = new ProjectTypeBL();
            return Ok(projectTypeBL.GetProjectType(projectTypeModel));
        }

        [UserAuthentication]
        [HttpPost]
        [ActionName("ProjectTypeCUD")]
        public IHttpActionResult ProjectTypeCUD([FromBody] ProjectTypeModel projectTypeModel)
        {
            ProjectTypeBL projectTypeBL = new ProjectTypeBL();
            return Ok(projectTypeBL.ProjectTypeCUD(projectTypeModel));
        }
    }
}
