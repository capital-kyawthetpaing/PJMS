using System;
using System.Collections.Generic;
using PJMS_Model;
namespace PJMS_Model
{
    public class ProjectModel : BaseModel
    {
        public string ProjectCD { get; set; }
        public string ProjectName { get; set; }
        public string CompanyName { get; set; }
        public string RelatedCompanyName { get; set; }
        public string PersonInCharge { get; set; }
        public string ProjectTypeCD { get; set; }
        public string ContractDate { get; set; }
        public string DeliveryDate { get; set; }
        public string StartDate { get; set; }
        public string PlanEndDate { get; set; }
        public string EndDate { get; set; }
        public string ProgressCD { get; set; }
        public string ProgressRate { get; set; }
        public string ContractAmount { get; set; }
        public string PhoneNo { get; set; }
        public string MailAddress { get; set; }
        public string BPO { get; set; }
        public string BillingTiming { get; set; }
        public string ProjectInfo { get; set; }
        public string Comment { get; set; }
        public string EmployeeCD { get; set; }
        public string EmployeeName { get; set; }    
        public string Photo { get; set; }
        public string Role { get; set; }
        public string ProjectDetailJson { get; set; }
    }
}
