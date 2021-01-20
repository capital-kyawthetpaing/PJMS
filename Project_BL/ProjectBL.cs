using CKM_CommonFunction;
using CKM_DataLayer;
using System.Data.SqlClient;
using PJMS_Model;

namespace Project_BL
{
    public class ProjectBL
    {
        CKMDL cKMDL;
        FileFunction ff;
        public ProjectBL()
        {
            cKMDL = new CKMDL();
            ff = new FileFunction();
        }
        public string GetProject(ProjectModel projectModel)
        {
            projectModel.Sqlprms = new SqlParameter[2];
            projectModel.Sqlprms[0] = new SqlParameter("@ProjectCD", projectModel.ProjectCD);
            projectModel.Sqlprms[1] = new SqlParameter("@ProjectName", projectModel.ProjectName);

            return cKMDL.SelectJson("Project_Select", ff.GetConnectionWithDefaultPath("PJMS"), projectModel.Sqlprms);
        }
    }
}
