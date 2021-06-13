using PJMS_Model;
using System.Web.Mvc;
using ProjectType_BL;

namespace PJMS_Web.Controllers
{
    public class ProjectTypeController : Controller
    {
        // GET: ProjectType
        public ActionResult ProjectTypeList()
        {
            return View();
        }

        public ActionResult ProjectTypeEntry(ProjectTypeModel projectTypeModel)
        {
            if (string.IsNullOrWhiteSpace(projectTypeModel.Mode))
                projectTypeModel.Mode = "New";
            return View(projectTypeModel);
        }
    }
}