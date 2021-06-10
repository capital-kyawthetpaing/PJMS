using System.Web.Http;
using PJMS_Model;
using MessageBL;

namespace PJMS_Web.Controllers
{
    public class MessageApiController : ApiController
    {
        // GET: MessageApi
        [UserAuthentication]
        [HttpPost]
        public string GetMessage([FromBody] MessageModel Mmodel)
        {
            if (Mmodel == null)
            {
                Mmodel = new MessageModel();
            }
            Message_BL msgBL = new Message_BL();
            return msgBL.M_Message_Select(Mmodel);
        }
    }
}