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

        [UserAuthentication]
        [HttpPost]
        [ActionName("GetProjectDetail")]
        public IHttpActionResult GetProjectDetail([FromBody] ProjectModel projectModel)
        {
            ProjectBL projectBL = new ProjectBL();
            return Ok(projectBL.GetProjectDetail(projectModel));
        }

        [UserAuthentication]
        [HttpPost]
        [ActionName("GetProjectView")]
        public IHttpActionResult GetProjectView([FromBody] ProjectModel projectModel)
        {
            ProjectBL projectBL = new ProjectBL();
            return Ok(projectBL.GetProjectView(projectModel));
        }

        [UserAuthentication]
        [HttpPost]
        [ActionName("InsertProjectDetail")]
        public IHttpActionResult InsertProjectDetail([FromBody] ProjectModel projectModel)
        {
            ProjectBL projectBL = new ProjectBL();
            return Ok(projectBL.InsertProjectDetail(projectModel));
        }

        //ssa CHG 09/06/2021
        //[UserAuthentication]
        //[HttpPost]
        //[ActionName("UpdateProjectDetail")]
        //public IHttpActionResult UpdateProjectDetail([FromBody] ProjectModel projectModel)
        //{
        //    ProjectBL projectBL = new ProjectBL();
        //    return Ok(projectBL.UpdateProjectDetail(projectModel));
        //}

    }
}
