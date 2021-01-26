using System.Web.Http;
using PJMS_Model;
using Employee_BL;

namespace PJMS_Web.Controllers
{
    public class EmployeeApiController : ApiController
    {
        [UserAuthentication]
        [HttpPost]
        [ActionName("GetEmployee")]
        public IHttpActionResult GetProject([FromBody] EmployeeModel employeeModel)
        {
            EmployeeBL employeeBL = new EmployeeBL();
            return Ok(employeeBL.GetEmployee(employeeModel));
        }
    }
}
