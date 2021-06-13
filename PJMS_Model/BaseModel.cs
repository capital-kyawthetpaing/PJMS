using System.Data.SqlClient;

namespace PJMS_Model
{
    public class BaseModel
    {
        public string Mode { get; set; }
        public string SPName { get; set; }
        public SqlParameter[] Sqlprms { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string param1 { get; set; }
        public string param2 { get; set; }
    }
}
