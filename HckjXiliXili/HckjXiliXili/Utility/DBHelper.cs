using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace HckjXiliXili.Utility
{
    class DBHelper
    {
        readonly static string connStr = ConfigurationManager.AppSettings["ConStr1"].ToString();

        static SqlConnection conn = new SqlConnection(connStr);

        public static SqlDataReader GetDataReader(string sql)
        {
            SqlConnection myConn = conn;
            SqlDataReader dr = null;

            myConn.Open();

            SqlCommand cmd = new SqlCommand(sql, myConn);
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            return dr;
        }

        public static object ExecuteScalar(string sql)
        {
            object result = null;
            SqlConnection sqlCon = conn;
            sqlCon.Open();

            SqlCommand sqlCmd = new SqlCommand(sql, sqlCon);
            result = sqlCmd.ExecuteScalar();

            sqlCon.Close();

            return result;
        }

        public static int ExecuteNonQuery(string sql)
        {
            int obj = 0;
            SqlConnection sqlCon =conn;
            try
            {
                sqlCon.Open();
            }
            catch (Exception ex)
            {
                //记录至Log文件  
                return obj;
            }

            SqlCommand sqlCmd = new SqlCommand(sql, sqlCon);
            obj = sqlCmd.ExecuteNonQuery();
            sqlCon.Close(); // 断开

            return obj;
        }
    }
}
