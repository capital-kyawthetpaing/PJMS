using CKM_CommonFunction;
using CKM_DataLayer;
using System.Data.SqlClient;
using PJMS_Model;
namespace User_BL
{
    public class UserBL
    {
        CKMDL cKMDL;
        FileFunction ff;
        public UserBL()
        {
            cKMDL = new CKMDL();
            ff = new FileFunction();
        }
        public string GetUser(UserModel userModel)
        {
            userModel.Sqlprms = new SqlParameter[2];
            userModel.Sqlprms[0] = new SqlParameter("@UserID", userModel.UserID);
            userModel.Sqlprms[1] = new SqlParameter("@Password", userModel.Password);
            return cKMDL.SelectJson("User_Select", ff.GetConnectionWithDefaultPath("PJMS"), userModel.Sqlprms);
        }
    }
}
