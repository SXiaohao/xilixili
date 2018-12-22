using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HckjXiliXili.Entity;
using HckjXiliXili.Utility;
using HckjXiliXili.Mapper;
using HckjXiliXili.View;

namespace HckjXiliXili
{
    public partial class CartoonCard : UserControl
    {
        private Cartoon cartoonlist;
        public CartoonCard(Cartoon cartoon)
        {
            InitializeComponent();
            this.cartoonlist = cartoon;
        }

        private void CartoonCard_Load(object sender, EventArgs e)
        {
            Cartoon_image.BackgroundImage = Image.FromFile(cartoonlist.Cartoon_image);
            Cartoon_name.Text = cartoonlist.Cartoon_name;
            Cartoon_old_name.Text = cartoonlist.Cartoon_old_name;
            Cartoon_type.Text = cartoonlist.Cartoon_type;
            Cartoon_text.Text = cartoonlist.Cartoon_text;
            Cartoon_studio.Text = cartoonlist.Cartoon_studio;
            Cartoon_director.Text = cartoonlist.Cartoon_director;
            Cartoon_count.Text = "共"+cartoonlist.Cartoon_count+"话";
            Cartoon_start_time.Text = cartoonlist.Cartoon_start_time;

        }
        public delegate void FormCloseEventHandler(object sender, EventArgs e);
        public event FormCloseEventHandler FormClose;
        private void Play_Click(object sender, EventArgs e)
        {
            PlayPage playPage = new PlayPage(cartoonlist.Cartoon_id,cartoonlist.Cartoon_name);
            FormClose(this, new EventArgs());
            playPage.ShowDialog();                      
        }
    }
}
