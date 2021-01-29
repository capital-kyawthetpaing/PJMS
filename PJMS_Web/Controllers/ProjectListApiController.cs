using System.Web.Http;
using PJMS_Model;
using Project_BL;

namespace PJMS_Web.Controllers
{
    public class ProjectListApiController : ApiController
    {
        [UserAuthentication]
        [HttpPost]
        [ActionName("GetProject")]
        public IHttpActionResult GetProject([FromBody] ProjectModel projectModel)
        {
            ProjectBL projectBL = new ProjectBL();
            return Ok(projectBL.GetProject(projectModel));
        }
       
    }
}
