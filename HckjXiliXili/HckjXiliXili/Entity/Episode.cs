using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HckjXiliXili.Entity
{
    public class Episode
    {
        private int cartoon_id;
        private int episode_no;
        private string episode_link;
        private string episode_name;

        public int Cartoon_id { get => cartoon_id; set => cartoon_id = value; }
        public int Episode_no { get => episode_no; set => episode_no = value; }
        public string Episode_link { get => episode_link; set => episode_link = value; }
        public string Episode_name { get => episode_name; set => episode_name = value; }
    }
}
