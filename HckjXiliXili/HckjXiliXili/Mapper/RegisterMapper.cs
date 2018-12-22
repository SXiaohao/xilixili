using HckjXiliXili.Enum;
using HckjXiliXili.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HckjXiliXili.Mapper
{
    class RegisterMapper
    {
        public static RegisterState Submit(string phone, string pwd, string pwd2)
        {
            string sql = "INSERT INTO User_ VALUES (" + phone + "," + pwd + ")";
            if (phone == "")
            {
                return RegisterState.phoneempty;
            }else if (pwd == "" || pwd2 == "")
            {
                return RegisterState.pwdempty;
            }else if (pwd != pwd2)
            {
                return RegisterState.inconformity;
            }else if (!IsPhone(phone))
            {
                return RegisterState.phoneerror;
            }else if (DBHelper.ExecuteNonQuery(sql)==1)
            {
                return RegisterState.sucess;
            }
            return RegisterState.error;
        }
        public static bool IsPhone(string str_phone)
        {
            return Regex.IsMatch(str_phone, @"^(13[0-9]|14[579]|15[0-3,5-9]|16[6]|17[0135678]|18[0-9]|19[89])\d{8}$");
        }
    }
}
