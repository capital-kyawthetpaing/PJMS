using CKM_CommonFunction;
using CKM_DataLayer;
using System.Data.SqlClient;
using PJMS_Model;

namespace MessageBL
{
    public class Message_BL
    {
        CKMDL cKMDL;
        FileFunction ff;
        public Message_BL()
        {
            cKMDL = new CKMDL();
            ff = new FileFunction();
        }
        public string M_Message_Select(MessageModel Mmodel)
        {
            Mmodel.Sqlprms = new SqlParameter[1];
            Mmodel.Sqlprms[0] = new SqlParameter("@MessageID", Mmodel.MessageID);
            return cKMDL.SelectJson("M_Message_Select", ff.GetConnectionWithDefaultPath("PJMS"), Mmodel.Sqlprms);
        }
    }
}
