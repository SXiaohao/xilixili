using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HckjXiliXili.Entity
{
    public class New
    {
        private int new_id;
        private string new_image;
        private string new_name;
        private string new_text;

        public int New_id { get => new_id; set => new_id = value; }
        public string New_image { get => new_image; set => new_image = value; }
        public string New_name { get => new_name; set => new_name = value; }
        public string New_text { get => new_text; set => new_text = value; }
    }
}
