using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HckjXiliXili.Entity
{
    public class Cartoon
    {
        private int new_id;
        private int cartoon_id;
        private string cartoon_name;
        private string cartoon_old_name;
        private string cartoon_director;
        private int cartoon_count;
        private string cartoon_start_time;
        private string cartoon_type;
        private string cartoon_text;
        private string cartoon_studio;
        private string cartoon_image;

        public int New_id { get => new_id; set => new_id = value; }
        public string Cartoon_name { get => cartoon_name; set => cartoon_name = value; }
        public string Cartoon_old_name { get => cartoon_old_name; set => cartoon_old_name = value; }
        public string Cartoon_director { get => cartoon_director; set => cartoon_director = value; }
        public int Cartoon_count { get => cartoon_count; set => cartoon_count = value; }
        public string Cartoon_start_time { get => cartoon_start_time; set => cartoon_start_time = value; }
        public string Cartoon_type { get => cartoon_type; set => cartoon_type = value; }
        public string Cartoon_text { get => cartoon_text; set => cartoon_text = value; }
        public string Cartoon_studio { get => cartoon_studio; set => cartoon_studio = value; }
        public string Cartoon_image { get => cartoon_image; set => cartoon_image = value; }
        public int Cartoon_id { get => cartoon_id; set => cartoon_id = value; }
    }
}
