using CCWin;
using HckjXiliXili.Enum;
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
using System.Windows.Forms;

namespace HckjXiliXili
{
    public delegate void TransfDelegate(String value);
    public partial class RegisterPage : CCSkinMain
    {
        public event TransfDelegate TransfEvent;
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void RegisterPage_Load(object sender, EventArgs e)
        {
            Bitmap bitmapG = new Bitmap(@"..\..\UI\Images\mouse.png");
            this.Cursor = new Cursor(bitmapG.GetHicon());
        }
        
        private void skinButton1_Click(object sender, EventArgs e)
        {
            RegisterState registerState = RegisterMapper.Submit(Phone.Text, Pwd.Text, Pwd2.Text);
           if (registerState == RegisterState.sucess)
            {
                MessageBox.Show(StateString.GetRegisterStateString(registerState));
                TransfEvent(Phone.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show(StateString.GetRegisterStateString(registerState));
            }
        }
    }
}
