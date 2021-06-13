using CKM_CommonFunction;
using CKM_DataLayer;
using System.Data.SqlClient;
using PJMS_Model;

namespace ProjectType_BL
{
    public class ProjectTypeBL
    {
        CKMDL cKMDL;
        FileFunction ff;
        public ProjectTypeBL()
        {
            cKMDL = new CKMDL();
            ff = new FileFunction();
        }
        public string GetProjectType(ProjectTypeModel projectTypeModel)
        {
            projectTypeModel.Sqlprms = new SqlParameter[1];
            projectTypeModel.Sqlprms[0] = new SqlParameter("@ProjectTypeCD", projectTypeModel.ProjectTypeCD);
            return cKMDL.SelectJson("ProjectType_Select", ff.GetConnectionWithDefaultPath("PJMS"), projectTypeModel.Sqlprms);
        }

        public string ProjectTypeCUD(ProjectTypeModel projectTypeModel)
        {
            cKMDL.UseTran = true;//ssa chg 09_06_2021
            projectTypeModel.Sqlprms = new SqlParameter[4];
            projectTypeModel.Sqlprms[0] = new SqlParameter("@ProjectTypeCD", projectTypeModel.ProjectTypeCD);
            projectTypeModel.Sqlprms[1] = new SqlParameter("@ProjectTypeName", projectTypeModel.ProjectTypeName);
            projectTypeModel.Sqlprms[2] = new SqlParameter("@UpdatedBy", projectTypeModel.UpdatedBy);
            projectTypeModel.Sqlprms[3] = new SqlParameter("@Mode", projectTypeModel.Mode);
            return cKMDL.InsertUpdateDeleteData("ProjectType_CUD", ff.GetConnectionWithDefaultPath("PJMS"), projectTypeModel.Sqlprms);
        }

    }
}
