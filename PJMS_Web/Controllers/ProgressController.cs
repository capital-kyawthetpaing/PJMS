using System.Web.Mvc;
using PJMS_Model;

namespace PJMS_Web.Controllers
{
    public class ProgressController : Controller
    {
        public ActionResult ProgressList()
        {
            return View();
        }

        public ActionResult ProgressEntry(ProgressModel progressModel)
        {
            if (string.IsNullOrWhiteSpace(progressModel.Mode))
                progressModel.Mode = "New";
            return View(progressModel);
        }
    }
}