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
            projectModel.Sqlprms = new SqlParameter[3];
            projectModel.Sqlprms[0] = new SqlParameter("@ProjectCD", projectModel.ProjectCD);
            projectModel.Sqlprms[1] = new SqlParameter("@ProjectName", projectModel.ProjectName);
            projectModel.Sqlprms[2] = new SqlParameter("@ProjectType", projectModel.ProjectTypeCD);
            return cKMDL.SelectJson("Project_Select", ff.GetConnectionWithDefaultPath("PJMS"), projectModel.Sqlprms);
        }
        public string InsertProject(ProjectModel projectModel)
        {
            cKMDL.UseTran = true;//ssa chg 09_06_2021
            projectModel.Sqlprms = new SqlParameter[7];
            projectModel.Sqlprms[0] = new SqlParameter("@ProjectCD", projectModel.ProjectCD);
            projectModel.Sqlprms[1] = new SqlParameter("@ProjectName", projectModel.ProjectName);
            projectModel.Sqlprms[2] = new SqlParameter("@ProjectType", projectModel.ProjectTypeCD);
            projectModel.Sqlprms[3] = new SqlParameter("@CompanyName", projectModel.CompanyName);
            projectModel.Sqlprms[4] = new SqlParameter("@PresonInCharge", projectModel.PersonInCharge);
            projectModel.Sqlprms[5] = new SqlParameter("@ContractDate", projectModel.ContractDate);
            projectModel.Sqlprms[6] = new SqlParameter("@ProjectDetailJson", projectModel.ProjectDetailJson);
            //projectModel.Sqlprms[7] = new SqlParameter("@Role", projectModel.Role);
            return cKMDL.InsertUpdateDeleteData("Project_Insert", ff.GetConnectionWithDefaultPath("PJMS"), projectModel.Sqlprms);
        }

        public string ProjectCUD(ProjectModel projectModel)
        {
            cKMDL.UseTran = true;//ssa chg 09_06_2021
            projectModel.Sqlprms = new SqlParameter[21];
            projectModel.Sqlprms[0] = new SqlParameter("@ProjectCD", projectModel.ProjectCD);
            projectModel.Sqlprms[1] = new SqlParameter("@ProjectName", projectModel.ProjectName);
            projectModel.Sqlprms[2] = new SqlParameter("@CompanyName", projectModel.CompanyName);
            projectModel.Sqlprms[3] = new SqlParameter("@PersonInCharge", projectModel.PersonInCharge);
            projectModel.Sqlprms[4] = new SqlParameter("@ProjectTypeCD", projectModel.ProjectTypeCD);
            projectModel.Sqlprms[5] = new SqlParameter("@ContractDate", projectModel.ContractDate);
            projectModel.Sqlprms[6] = new SqlParameter("@StartDate", projectModel.StartDate);
            projectModel.Sqlprms[7] = new SqlParameter("@PlanEndDate", projectModel.PlanEndDate);
            projectModel.Sqlprms[8] = new SqlParameter("@EndDate", projectModel.EndDate);
            projectModel.Sqlprms[9] = new SqlParameter("@ProgressCD", projectModel.ProgressCD);
            projectModel.Sqlprms[10] = new SqlParameter("@ContractAmount", projectModel.ContractAmount);
            projectModel.Sqlprms[11] = new SqlParameter("@PhoneNo", projectModel.PhoneNo);
            projectModel.Sqlprms[12] = new SqlParameter("@MailAddress", projectModel.MailAddress);
            projectModel.Sqlprms[13] = new SqlParameter("@BPO", projectModel.BPO);
            projectModel.Sqlprms[14] = new SqlParameter("@BillingTiming", projectModel.BillingTiming);
            projectModel.Sqlprms[15] = new SqlParameter("@ProjectInfo", projectModel.ProjectInfo);
            projectModel.Sqlprms[16] = new SqlParameter("@Comment", projectModel.Comment);
            projectModel.Sqlprms[17] = new SqlParameter("@ProjectDetailJson", projectModel.ProjectDetailJson);
            projectModel.Sqlprms[18] = new SqlParameter("@UpdatedBy", projectModel.UpdatedBy);
            projectModel.Sqlprms[19] = new SqlParameter("@Mode", projectModel.Mode);
            projectModel.Sqlprms[20] = new SqlParameter("@RelatedCompanyName", projectModel.RelatedCompanyName);
            return cKMDL.InsertUpdateDeleteData("Project_CUD", ff.GetConnectionWithDefaultPath("PJMS"), projectModel.Sqlprms);
        }

        public string UpdateProject(ProjectModel projectModel)
        {
            cKMDL.UseTran = true;//ssa chg 09_06_2021
            projectModel.Sqlprms = new SqlParameter[7];
            projectModel.Sqlprms[0] = new SqlParameter("@ProjectCD", projectModel.ProjectCD);
            projectModel.Sqlprms[1] = new SqlParameter("@ProjectName", projectModel.ProjectName);
            projectModel.Sqlprms[2] = new SqlParameter("@ProjectType", projectModel.ProjectTypeCD);
            projectModel.Sqlprms[3] = new SqlParameter("@CompanyName", projectModel.CompanyName);
            projectModel.Sqlprms[4] = new SqlParameter("@PresonInCharge", projectModel.PersonInCharge);
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
            projectModel.Sqlprms = new SqlParameter[6];
            projectModel.Sqlprms[0] = new SqlParameter("@ProjectCD", projectModel.ProjectCD);
            projectModel.Sqlprms[1] = new SqlParameter("@ProjectName", projectModel.ProjectName);
            projectModel.Sqlprms[2] = new SqlParameter("@ProjectTypeCD", projectModel.ProjectTypeCD);
            projectModel.Sqlprms[3] = new SqlParameter("@CompanyName", projectModel.CompanyName);
            projectModel.Sqlprms[4] = new SqlParameter("@PersonInCharge", projectModel.PersonInCharge);
            projectModel.Sqlprms[5] = new SqlParameter("@ProgressCD", projectModel.ProgressCD);
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
