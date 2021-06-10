using System;
using System.Collections.Generic;
using PJMS_Model;

namespace PJMS_Model
{
    public class MessageModel: BaseModel
    {
        public string MessageID { get; set; }
        public string MessageText1 { get; set; }
        public string MessageButton { get; set; }
    }
}
