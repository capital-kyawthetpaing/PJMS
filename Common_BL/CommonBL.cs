using CKM_CommonFunction;
using CKM_DataLayer;
using System.Data.SqlClient;
using PJMS_Model;
using System.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Common_BL
{
    public class CommonBL
    {
        CKMDL cKMDL;
        FileFunction ff;
        public CommonBL()
        {
            cKMDL = new CKMDL();
            ff = new FileFunction();
        }

        public string Date_Checking(string inputdate)
        {

            string strdate = string.Empty;
            if (!string.IsNullOrWhiteSpace(inputdate))
            {
                if (IsInteger(inputdate.Replace("/", "").Replace("-", "")))
                {
                    string day = string.Empty, month = string.Empty, year = string.Empty;
                    if (inputdate.Contains("/"))
                    {
                        string[] date = inputdate.Split('/');
                        day = date[date.Length - 1].PadLeft(2, '0');
                        month = date[date.Length - 2].PadLeft(2, '0');

                        if (date.Length > 2)
                            year = date[date.Length - 3];

                        inputdate = year + month + day;
                    }
                    else if (inputdate.Contains("-"))
                    {
                        string[] date = inputdate.Split('-');
                        day = date[date.Length - 1].PadLeft(2, '0');
                        month = date[date.Length - 2].PadLeft(2, '0');

                        if (date.Length > 2)
                            year = date[date.Length - 3];

                        inputdate = year + month + day;
                    }

                    string text = inputdate;
                    text = text.PadLeft(8, '0');
                    day = text.Substring(text.Length - 2);
                    month = text.Substring(text.Length - 4).Substring(0, 2);
                    year = Convert.ToInt32(text.Substring(0, text.Length - 4)).ToString();

                    if (month == "00")
                    {
                        month = string.Empty;
                    }
                    if (year == "0")
                    {
                        year = string.Empty;
                    }

                    if (string.IsNullOrWhiteSpace(month))
                        month = DateTime.Now.Month.ToString().PadLeft(2, '0');//if user doesn't input for month,set current month

                    if (string.IsNullOrWhiteSpace(year))
                    {
                        year = DateTime.Now.Year.ToString();//if user doesn't input for year,set current year
                    }
                    else
                    {
                        if (year.Length == 1)
                            year = "200" + year;
                        else if (year.Length == 2)
                            year = "20" + year;
                    }
                    strdate = year + "/" + month + "/" + day;
                    if (CheckDate(strdate))
                    {
                        //result = "[{\"resultdate\" : \"" + strdate + "\", \"flg\" : \"true\"}]";   //"[{"result":"2020/01/01"}]";                      
                        return strdate;
                    }
                    else
                    {
                        //result = "[{\"resultdate\" : \"" + strdate + "\", \"flg\" : \"false\"}]";
                        return "NG";
                        //mmodel = new MessageModel()
                        //{
                        //    MessageID = "E103"
                        //};
                        //errmsg = mbl.M_Message_Select(mmodel);
                        //return errmsg;
                    }
                }
                else
                {
                    //result = "[{\"resultdate\" : \"" + strdate + "\", \"flg\" : \"false\"}]";
                    return "NG";
                    //mmodel = new MessageModel()
                    //{
                    //    MessageID = "E103"
                    //};
                    //errmsg = mbl.M_Message_Select(mmodel);
                    //return errmsg;
                }
            }
            else
            {
                //result = "[{\"resultdate\" : \"" + strdate + "\", \"flg\" : \"true\"}]";
                return strdate;
            }
        }

        public bool IsInteger(string value)
        {
            value = value.Replace("-", "");
            if (Int64.TryParse(value, out Int64 Num))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckDate(string value)
        {
            return DateTime.TryParseExact(value,
                       "yyyy/MM/dd",
                       System.Globalization.CultureInfo.InvariantCulture,
                       DateTimeStyles.None,
                       out DateTime d);
        }

        public string ExistsCheck(BaseModel baseModel)
        {
            baseModel.Sqlprms = new SqlParameter[2];
            baseModel.Sqlprms[0] = new SqlParameter("@param1", baseModel.param1);
            baseModel.Sqlprms[1] = new SqlParameter("@param2", baseModel.param2);
            DataTable dt = cKMDL.SelectDatatable("Check_DataExists", ff.GetConnectionWithDefaultPath("PJMS"), baseModel.Sqlprms);
            if (dt.Rows.Count > 0)
                return "1";
            return "0";
        }

        public string ByteLengthCheck(BaseModel baseModel)
        {
            if(baseModel.param1 != null)
            {
                int i = Encoding.GetEncoding(932).GetByteCount(baseModel.param1);
                if (i > Convert.ToInt32(baseModel.param2))
                    return "0";
                return "1";
            }
            return "1";
        }
    }
}
