using System;
using System.Collections.Generic;
using PJMS_Model;
namespace PJMS_Model
{
    public class ProjectModel : BaseModel
    {
        public string Teams { get; set; }
        public string Projects { get; set; }
        public string ProjectLeaders { get; set; }
        public string ProjectMembers { get; set; }
        public string SystemTeam { get; set; }
        public string SeisakuTeam { get; set; }
        public string ProjectCD { get; set; }
        public string EmployeeCD { get; set; }
        public string ProjectName { get; set; }
        public string EmployeeName { get; set; }
        public string TeamID { get; set; }
        public string CompanyName { get; set; }
        public string PresonInCharge { get; set; }
        public string Photo { get; set; }
        public string ContractDate { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Role { get; set; }
        public string ProjectDetailJson { get; set; }
    }
}
