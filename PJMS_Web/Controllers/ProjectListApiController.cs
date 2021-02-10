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

        [UserAuthentication]
        [HttpPost]
        [ActionName("InsertProject")]
        public IHttpActionResult InsertProject([FromBody] ProjectModel projectModel)
        {
            ProjectBL projectBL = new ProjectBL();
            return Ok(projectBL.InsertProject(projectModel));
        }

        [UserAuthentication]
        [HttpPost]
        [ActionName("UpdateProject")]
        public IHttpActionResult UpdateProject([FromBody] ProjectModel projectModel)
        {
            ProjectBL projectBL = new ProjectBL();
            return Ok(projectBL.UpdateProject(projectModel));
        }

    }
}
