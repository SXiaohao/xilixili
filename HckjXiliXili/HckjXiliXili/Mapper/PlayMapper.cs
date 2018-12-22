using HckjXiliXili.Entity;
using HckjXiliXili.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HckjXiliXili.Mapper
{
    class PlayMapper
    {
        public static List<Episode> FindAll(int cartoon_id)
        {
            string sql = "select * from Episode where cartoon_id=" + cartoon_id;
            List<Episode> episodeList = new List<Episode>();
            SqlDataReader dr = DBHelper.GetDataReader(sql);

            while (dr.Read())
            {
                Episode episode = new Episode();
                episode.Cartoon_id = Convert.ToInt16(dr[0]);
                episode.Episode_no = Convert.ToInt16(dr[1]);
                episode.Episode_link = dr[2].ToString();
                episode.Episode_name = dr[3].ToString();
                episodeList.Add(episode);
            }
            dr.Close();
            return episodeList;
        }

    }
}
