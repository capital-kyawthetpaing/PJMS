using PJMS_Model;
using Project_BL;
using System.Web.Mvc;

namespace PJMS_Web.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        public ActionResult ProjectList()
        {
            return View();
        }
        public ActionResult ProjectEntry(ProjectModel pModel)
        {
            if (string.IsNullOrWhiteSpace(pModel.Mode))
                pModel.Mode = "New";
            return View(pModel);

        }
        public ActionResult Project_Save(ProjectModel projectModel)
        {
            return RedirectToAction("ProjectList");
        }
        public ActionResult ProjectTeamSetUp()
        {
            return View();
        }
    }
}