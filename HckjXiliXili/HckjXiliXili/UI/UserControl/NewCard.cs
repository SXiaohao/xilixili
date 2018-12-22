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

namespace HckjXiliXili
{
    public partial class NewCard : UserControl
    {
        private New newlist;
        public NewCard(New newlist)
        {
            InitializeComponent();
            this.newlist = newlist;
        }

        private void NewCard_Load(object sender, EventArgs e)
        {
            this.New_image.BackgroundImage = Image.FromFile(newlist.New_image);
            this.New_name.Text = newlist.New_name;
            this.New_text.Text = newlist.New_text;
        }

        private void NewCard_Click(object sender, EventArgs e)
        {
            CartoonPage cartoonPage = new CartoonPage(newlist.New_id);
            cartoonPage.Show();
        }
    }
}
