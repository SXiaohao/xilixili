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
    public partial class xilixili : CCSkinMain
    {
      
        public xilixili()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            Bitmap bitmapG = new Bitmap(@"..\..\UI\Images\mouse.png");
            this.Cursor = new Cursor(bitmapG.GetHicon()); 

            
            int rank=-1;
            foreach(New newlist in NewMapper.FindAll())
            {
                rank++;
                NewCard newCard = new NewCard(newlist);
                newCard.Location = new Point(310 * (rank%3) + 40, 20 + rank/3 * 400);
                this.skinPanel1.Controls.Add(newCard);
            }

        }

       
    }
}
