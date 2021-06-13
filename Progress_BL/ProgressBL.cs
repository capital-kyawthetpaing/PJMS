using CKM_CommonFunction;
using CKM_DataLayer;
using System.Data.SqlClient;
using PJMS_Model;


namespace Progress_BL
{
    public class ProgressBL
    {
        CKMDL cKMDL;
        FileFunction ff;
        public ProgressBL()
        {
            cKMDL = new CKMDL();
            ff = new FileFunction();
        }
        public string GetProgress(ProgressModel progressModel)
        {
            progressModel.Sqlprms = new SqlParameter[1];
            progressModel.Sqlprms[0] = new SqlParameter("@ProgressCD", progressModel.ProgressCD);
            return cKMDL.SelectJson("Progress_Select", ff.GetConnectionWithDefaultPath("PJMS"), progressModel.Sqlprms);
        }

        public string ProgressCUD(ProgressModel progressModel)
        {
            cKMDL.UseTran = true;
            progressModel.Sqlprms = new SqlParameter[4];
            progressModel.Sqlprms[0] = new SqlParameter("@ProgressCD", progressModel.ProgressCD);
            progressModel.Sqlprms[1] = new SqlParameter("@ProgressName", progressModel.ProgressName);
            progressModel.Sqlprms[2] = new SqlParameter("@UpdatedBy", progressModel.UpdatedBy);
            progressModel.Sqlprms[3] = new SqlParameter("@Mode", progressModel.Mode);
            return cKMDL.InsertUpdateDeleteData("Progress_CUD", ff.GetConnectionWithDefaultPath("PJMS"), progressModel.Sqlprms);
        }
    }
}
