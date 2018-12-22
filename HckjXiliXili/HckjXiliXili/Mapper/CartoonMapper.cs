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
    class CartoonMapper
    {
        public static List<Cartoon> FindAll(int new_id)
        {
            string sql = "select * from Cartoon where new_id=" + new_id;
            List<Cartoon> newList = new List<Cartoon>();
            SqlDataReader dr = DBHelper.GetDataReader(sql);          
            while (dr.Read())
            {
                Cartoon cartoon = new Cartoon();
                cartoon.New_id = Convert.ToInt16(dr[0]);
                cartoon.Cartoon_id = Convert.ToInt16(dr[1]);
                cartoon.Cartoon_name = dr[2].ToString();
                cartoon.Cartoon_director = dr[3].ToString();
                cartoon.Cartoon_count = Convert.ToInt16(dr[4]);
                cartoon.Cartoon_start_time = ((DateTime)dr[5]).ToString("yyyy/MM/dd HH:mm");
                cartoon.Cartoon_type = dr[6].ToString();
                cartoon.Cartoon_old_name = dr[7].ToString();
                cartoon.Cartoon_text = dr[8].ToString();
                cartoon.Cartoon_image = dr[9].ToString();
                cartoon.Cartoon_studio = dr[10].ToString();
                newList.Add(cartoon);
            }
            dr.Close();
            return newList;
        }

    }
}
