using CKM_CommonFunction;
using CKM_DataLayer;
using System.Data.SqlClient;
using PJMS_Model;

namespace Employee_BL
{
    public class EmployeeBL
    {
        CKMDL cKMDL;
        FileFunction ff;
        public EmployeeBL()
        {
            cKMDL = new CKMDL();
            ff = new FileFunction();
        }
        public string GetEmployee(EmployeeModel employeeModel)
        {
            employeeModel.Sqlprms = new SqlParameter[2];
            employeeModel.Sqlprms[0] = new SqlParameter("@EmployeeCD", employeeModel.EmployeeCD);
            employeeModel.Sqlprms[1] = new SqlParameter("@EmployeeName", employeeModel.EmployeeName);
            return cKMDL.SelectJson("Employee_Select", ff.GetConnectionWithDefaultPath("PJMS"), employeeModel.Sqlprms);
        }
        public string InsertEmployee(EmployeeModel employeeModel)
        {
            employeeModel.Sqlprms = new SqlParameter[2];
            employeeModel.Sqlprms[0] = new SqlParameter("@EmployeeCD", employeeModel.EmployeeCD);
            employeeModel.Sqlprms[1] = new SqlParameter("@EmployeeName", employeeModel.EmployeeName);
            return cKMDL.InsertUpdateDeleteData("Employee_Insert", ff.GetConnectionWithDefaultPath("PJMS"), employeeModel.Sqlprms);
        }
        public string UpdateEmployee(EmployeeModel employeeModel)
        {
            employeeModel.Sqlprms = new SqlParameter[2];
            employeeModel.Sqlprms[0] = new SqlParameter("@EmployeeCD", employeeModel.EmployeeCD);
            employeeModel.Sqlprms[1] = new SqlParameter("@EmployeeName", employeeModel.EmployeeName);
            return cKMDL.InsertUpdateDeleteData("Employee_Update", ff.GetConnectionWithDefaultPath("PJMS"), employeeModel.Sqlprms);
        }      
    }
}
