using CCWin;
using HckjXiliXili.Mapper;
using HckjXiliXili.Utility;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HckjXiliXili
{

    public partial class LoginPage : CCSkinMain
    {

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            Bitmap bitmapG = new Bitmap(@"..\..\UI\Images\mouse.png");
            this.Cursor = new Cursor(bitmapG.GetHicon());
        }

        private void skinLabel3_Click(object sender, EventArgs e)
        {
            LoginState loginState= LoginMapper.Exist(Phone.Text.Trim(), Pwd.Text.Trim()) ;
            if (loginState== LoginState.sucess)
            {
                xilixili xilixili = new xilixili();
                this.Visible = false;
                xilixili.ShowDialog();
                this.Dispose();
                this.Close();
            }
            else
            {
                MessageBox.Show(StateString.GetLoginStateString(loginState));
            }
        }

        private void skinLabel4_Click(object sender, EventArgs e)
        {
            RegisterPage registerPage = new RegisterPage();
            registerPage.TransfEvent += RegisterPage_TransfEvent;
            registerPage.ShowDialog();
            
        }
        public void RegisterPage_TransfEvent(string value)
        {
            Phone.Text = value;
        }
    }
}
