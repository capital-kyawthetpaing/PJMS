using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJMS_Model
{
    public class EmployeeModel : BaseModel
    {
        public string EmployeeCD { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePhoto { get; set; }
        public string ProjectType { get; set; }
        public string EmployeeJson { get; set; }
    }
}
