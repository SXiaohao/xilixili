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
    public partial class EpisodeBtnCard : UserControl
    {
        private Episode episode;
        public EpisodeBtnCard(Episode episode)
        {
            InitializeComponent();
            this.episode = episode;
        }
        public delegate void deleset(Episode episode);
        public event deleset Delevent;

        private void skinButton1_Click(object sender, EventArgs e)
        {
            Delevent(episode);
        }

        private void EpisodeBtnCard_Load(object sender, EventArgs e)
        {
            this.skinButton1.Text = episode.Episode_no.ToString();
        }
    }
}
