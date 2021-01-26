using System;

namespace PJMS_Model
{
    public class ProjectModel : BaseModel
    {
        public string ProjectCD { get; set; }
        public string ProjectName { get; set; }
        public int TeamID { get; set; }
        public string CompanyName { get; set; }
        public string PresonInCharge { get; set; }
        public string Photo { get; set; }
        public string ContractDate { get; set; }
    }
}
