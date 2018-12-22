using CCWin;
using HckjXiliXili.Entity;
using HckjXiliXili.Mapper;
using HckjXiliXili.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace HckjXiliXili.View
{
    public partial class PlayPage : CCSkinMain
    {
        private int cartoon_id;
        private string cartoon_name;
        public PlayPage(int cartoon_id,string cartoon_name)
        {
            InitializeComponent();
            this.cartoon_id = cartoon_id;
            this.cartoon_name = cartoon_name;
            WebBrowserFeatures.SetWebBrowserFeatures();
        }

        private void PlayPage_Load(object sender, EventArgs e)
        {
            Bitmap bitmapG = new Bitmap(@"..\..\UI\Images\mouse.png");
            this.Cursor = new Cursor(bitmapG.GetHicon());

            foreach (Episode episode in PlayMapper.FindAll(cartoon_id))
            {
                EpisodeBtnCard episodeBtnCard = new EpisodeBtnCard(episode);
                episodeBtnCard.Delevent += new EpisodeBtnCard.deleset(set);
                this.skinFlowLayoutPanel1.Controls.Add(episodeBtnCard);
            }
            
        }
        public void set(Episode episode)
        {
            this.webBrowser1.Navigate(episode.Episode_link);
            this.skinLabel1.Text = cartoon_name + " > 第" + episode.Episode_no + "话 > " + episode.Episode_name;
        }

        private void PlayPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
