using CCWin;
using HckjXiliXili.Entity;
using HckjXiliXili.Mapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HckjXiliXili
{
    public partial class CartoonPage : CCSkinMain
    {
        private int new_id;
        public CartoonPage(int new_id)
        {
            InitializeComponent();
            this.new_id = new_id;
        }

        private void CartoonPage_Load(object sender, EventArgs e)
        {
            Bitmap bitmapG = new Bitmap(@"..\..\UI\Images\mouse.png");
            this.Cursor = new Cursor(bitmapG.GetHicon());

            foreach (Cartoon cartoon in CartoonMapper.FindAll(new_id))
            {
                CartoonCard card = new CartoonCard(cartoon);                
                card.FormClose += new CartoonCard.FormCloseEventHandler(this.UserControl_FormClose);
                this.skinFlowLayoutPanel1.Controls.Add(card);
            }
        }

        private void UserControl_FormClose(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
