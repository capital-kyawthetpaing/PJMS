using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using Progress_BL;
using PJMS_Model;


namespace PJMS_Web.Controllers
{
    public class ProgressApiController : ApiController
    {
        [UserAuthentication]
        [HttpPost]
        [ActionName("GetProgress")]
        public IHttpActionResult GetProgress([FromBody] ProgressModel progressModel)
        {
            ProgressBL progressBL = new ProgressBL();
            return Ok(progressBL.GetProgress(progressModel));
        }

        [UserAuthentication]
        [HttpPost]
        [ActionName("ProgressCUD")]
        public IHttpActionResult ProgressCUD([FromBody] ProgressModel progressModel)
        {
            ProgressBL progressBL = new ProgressBL();
            return Ok(progressBL.ProgressCUD(progressModel));
        }
    }
}
