using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HckjXiliXili.Entity
{
    public class User
    {
        private int user_id;
        private string user_phone;
        private string user_pwd;

        public int User_id { get => user_id; set => user_id = value; }
        public string User_name { get => user_phone; set => user_phone = value; }
        public string User_pwd { get => user_pwd; set => user_pwd = value; }
    }
}
