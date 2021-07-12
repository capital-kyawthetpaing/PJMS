using System.Web.Http;
using PJMS_Model;
using User_BL;

namespace PJMS_Web.Controllers
{
    public class UserApiController : ApiController
    {
        [UserAuthentication]
        [HttpPost]
        [ActionName("GetUser")]
        public IHttpActionResult GetUser([FromBody] UserModel userModel)
        {
            UserBL userBL = new UserBL();
            return Ok(userBL.GetUser(userModel));
        }
    }
}
