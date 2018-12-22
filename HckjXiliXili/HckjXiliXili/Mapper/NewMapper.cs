using HckjXiliXili.Entity;
using HckjXiliXili.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HckjXiliXili.Mapper
{
    class NewMapper
    {

        public static List<New>  FindAll()
        {
            string sql = "select * from New order by new_id DESC";
            List<New> newList = new List<New>();
            SqlDataReader dr = DBHelper.GetDataReader(sql);

            while (dr.Read())
            {
                New n = new New();
                n.New_id = Convert.ToInt16(dr[0]);
                n.New_image = dr[1].ToString();
                n.New_name = dr[2].ToString();
                n.New_text = dr[3].ToString();
                newList.Add(n);
            }
            dr.Close();
            return newList;
        }
    }
}
