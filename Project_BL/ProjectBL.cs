using CKM_CommonFunction;
using CKM_DataLayer;
using System.Data.SqlClient;
using PJMS_Model;
using System.Data;
using System;

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
        public string InsertProject(ProjectModel projectModel)
        {
            projectModel.Sqlprms = new SqlParameter[5];
            projectModel.Sqlprms[0] = new SqlParameter("@ProjectCD", projectModel.ProjectCD);
            projectModel.Sqlprms[1] = new SqlParameter("@ProjectName", projectModel.ProjectName);
            projectModel.Sqlprms[2] = new SqlParameter("@CompanyName", projectModel.CompanyName);
            projectModel.Sqlprms[3] = new SqlParameter("@PresonInCharge", projectModel.PresonInCharge);
            projectModel.Sqlprms[4] = new SqlParameter("@ContractDate", projectModel.ContractDate);
            return cKMDL.InsertUpdateDeleteData("Project_Insert", ff.GetConnectionWithDefaultPath("PJMS"), projectModel.Sqlprms);
        }
        public string UpdateProject(ProjectModel projectModel)
        {
            projectModel.Sqlprms = new SqlParameter[5];
            projectModel.Sqlprms[0] = new SqlParameter("@ProjectCD", projectModel.ProjectCD);
            projectModel.Sqlprms[1] = new SqlParameter("@ProjectName", projectModel.ProjectName);
            projectModel.Sqlprms[2] = new SqlParameter("@CompanyName", projectModel.CompanyName);
            projectModel.Sqlprms[3] = new SqlParameter("@PresonInCharge", projectModel.PresonInCharge);
            projectModel.Sqlprms[4] = new SqlParameter("@ContractDate", projectModel.ContractDate);
            return cKMDL.InsertUpdateDeleteData("Project_Update", ff.GetConnectionWithDefaultPath("PJMS"), projectModel.Sqlprms);
        }
    }
}
