using System.Web.Http;
using PJMS_Model;
using Common_BL;

namespace PJMS_Web.Controllers
{
    public class ErrorApiController : ApiController
    {
        [UserAuthentication]
        [HttpPost]
        [ActionName("ExistsCheck")]
        public IHttpActionResult ExistsCheck([FromBody] BaseModel baseModel)
        {
            CommonBL commonBL = new CommonBL();
            return Ok(commonBL.ExistsCheck(baseModel));
        }

        [UserAuthentication]
        [HttpPost]
        [ActionName("ByteLengthCheck")]
        public IHttpActionResult ByteLengthCheck([FromBody] BaseModel baseModel)
        {
            CommonBL commonBL = new CommonBL();
            return Ok(commonBL.ByteLengthCheck(baseModel));
        }

        [UserAuthentication]
        [HttpPost]
        [ActionName("DateCheck")]
        public IHttpActionResult DateCheck([FromBody] BaseModel baseModel)
        {
            CommonBL commonBL = new CommonBL();
            return Ok(commonBL.Date_Checking(baseModel.param1));
        }
    }
}
