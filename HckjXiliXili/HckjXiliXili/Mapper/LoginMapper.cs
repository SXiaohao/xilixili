using HckjXiliXili.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HckjXiliXili.Mapper
{
    public class LoginMapper
    {
        public static LoginState Exist(string phone, string pwd)
        {
            string sql = "SELECT user_pwd FROM User_ where user_phone='" + phone + "'";
            string pwd1 = Convert.ToString(DBHelper.ExecuteScalar(sql));
            if (phone == "")
            {
                return LoginState.phoneempty;
            }
            else if (pwd == "")
            {
                return LoginState.pwdempty;
            }else if (pwd1 == "")
            {
                return LoginState.noexist;
            }else if (pwd1 != "")
            {
                if (pwd1 == pwd)
                {
                    return LoginState.sucess;
                }
                return LoginState.pwderror;
            }
            return LoginState.error;
        }
    }
}
