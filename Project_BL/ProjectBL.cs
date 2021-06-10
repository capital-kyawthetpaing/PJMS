using CKM_CommonFunction;
using CKM_DataLayer;
using System.Data.SqlClient;
using PJMS_Model;
using System.Data;
using System;
using System.Collections;
using System.Collections.Generic;

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
            projectModel.Sqlprms = new SqlParameter[3];
            projectModel.Sqlprms[0] = new SqlParameter("@ProjectCD", projectModel.ProjectCD);
            projectModel.Sqlprms[1] = new SqlParameter("@ProjectName", projectModel.ProjectName);
            projectModel.Sqlprms[2] = new SqlParameter("@ProjectType", projectModel.ProjectType);
            return cKMDL.SelectJson("Project_Select", ff.GetConnectionWithDefaultPath("PJMS"), projectModel.Sqlprms);
        }
        public string InsertProject(ProjectModel projectModel)
        {
            cKMDL.UseTran = true;//ssa chg 09_06_2021
            projectModel.Sqlprms = new SqlParameter[7];
            projectModel.Sqlprms[0] = new SqlParameter("@ProjectCD", projectModel.ProjectCD);
            projectModel.Sqlprms[1] = new SqlParameter("@ProjectName", projectModel.ProjectName);
            projectModel.Sqlprms[2] = new SqlParameter("@ProjectType", projectModel.ProjectType);
            projectModel.Sqlprms[3] = new SqlParameter("@CompanyName", projectModel.CompanyName);
            projectModel.Sqlprms[4] = new SqlParameter("@PresonInCharge", projectModel.PresonInCharge);
            projectModel.Sqlprms[5] = new SqlParameter("@ContractDate", projectModel.ContractDate);
            projectModel.Sqlprms[6] = new SqlParameter("@ProjectDetailJson", projectModel.ProjectDetailJson);
            //projectModel.Sqlprms[7] = new SqlParameter("@Role", projectModel.Role);
            return cKMDL.InsertUpdateDeleteData("Project_Insert", ff.GetConnectionWithDefaultPath("PJMS"), projectModel.Sqlprms);
        }

        public string UpdateProject(ProjectModel projectModel)
        {
            cKMDL.UseTran = true;//ssa chg 09_06_2021
            projectModel.Sqlprms = new SqlParameter[7];
            projectModel.Sqlprms[0] = new SqlParameter("@ProjectCD", projectModel.ProjectCD);
            projectModel.Sqlprms[1] = new SqlParameter("@ProjectName", projectModel.ProjectName);
            projectModel.Sqlprms[2] = new SqlParameter("@ProjectType", projectModel.ProjectType);
            projectModel.Sqlprms[3] = new SqlParameter("@CompanyName", projectModel.CompanyName);
            projectModel.Sqlprms[4] = new SqlParameter("@PresonInCharge", projectModel.PresonInCharge);
            projectModel.Sqlprms[5] = new SqlParameter("@ContractDate", projectModel.ContractDate);
            projectModel.Sqlprms[6] = new SqlParameter("@ProjectDetailJson", projectModel.ProjectDetailJson);
            return cKMDL.InsertUpdateDeleteData("Project_Update", ff.GetConnectionWithDefaultPath("PJMS"), projectModel.Sqlprms);
        }

        public string GetProjectDetail(ProjectModel projectModel)
        {
            projectModel.Sqlprms = new SqlParameter[5];
            projectModel.Sqlprms[0] = new SqlParameter("@ProjectCD", projectModel.ProjectCD);
            projectModel.Sqlprms[1] = new SqlParameter("@ProjectName", projectModel.ProjectName);
            projectModel.Sqlprms[2] = new SqlParameter("@EmployeeCD", projectModel.EmployeeCD);
            projectModel.Sqlprms[3] = new SqlParameter("@EmployeeName", projectModel.EmployeeName);
            projectModel.Sqlprms[4] = new SqlParameter("@Role", projectModel.Role);
            return cKMDL.SelectJson("Project_SelectDetail", ff.GetConnectionWithDefaultPath("PJMS"), projectModel.Sqlprms);
        }
        public string GetProjectView(ProjectModel projectModel)
        {
            projectModel.Sqlprms = new SqlParameter[1];
            projectModel.Sqlprms[0] = new SqlParameter("@ProjectCD", projectModel.ProjectCD);
            return cKMDL.SelectJson("ProjectView_Select", ff.GetConnectionWithDefaultPath("PJMS"), projectModel.Sqlprms);
        }
        public string InsertProjectDetail(ProjectModel projectModel)
        {
            projectModel.Sqlprms = new SqlParameter[3];
            projectModel.Sqlprms[0] = new SqlParameter("@ProjectCD", projectModel.ProjectCD);
            projectModel.Sqlprms[1] = new SqlParameter("@ProjectDetailJson", projectModel.ProjectDetailJson);
            projectModel.Sqlprms[2] = new SqlParameter("@Role", projectModel.Role);
            return cKMDL.InsertUpdateDeleteData("Project_InsertDetail", ff.GetConnectionWithDefaultPath("PJMS"), projectModel.Sqlprms);
        }
        public string UpdateProjectDetail(ProjectModel projectModel)
        {
            projectModel.Sqlprms = new SqlParameter[3];
            projectModel.Sqlprms[0] = new SqlParameter("@ProjectCD", projectModel.ProjectCD);
            projectModel.Sqlprms[1] = new SqlParameter("@ProjectDetailJson", projectModel.ProjectDetailJson);
            projectModel.Sqlprms[2] = new SqlParameter("@Role", projectModel.Role);
            return cKMDL.InsertUpdateDeleteData("Project_UpdateDetail", ff.GetConnectionWithDefaultPath("PJMS"), projectModel.Sqlprms);
        }
    }
}
