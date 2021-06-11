using System.Web.Http;
using PJMS_Model;
using Common_BL;
namespace PJMS_Web.Controllers
{
    public class CommonApiController : ApiController
    {
        // GET: CommonApi
        [UserAuthentication]
        [HttpPost]
        public string Date_Checking([FromBody] ProjectModel  pModel)
        {
            CommonBL cmbl = new CommonBL();
            return cmbl.Date_Checking(pModel.ContractDate);
        }
    }
}