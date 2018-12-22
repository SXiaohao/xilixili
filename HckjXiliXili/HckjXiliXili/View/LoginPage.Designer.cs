namespace HckjXiliXili
{
    partial class LoginPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.Phone = new CCWin.SkinControl.SkinTextBox();
            this.Pwd = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.gifBox1 = new CCWin.SkinControl.GifBox();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.Transparent;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.skinLabel1.Location = new System.Drawing.Point(551, 164);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(58, 22);
            this.skinLabel1.TabIndex = 2;
            this.skinLabel1.Text = "手机号";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.Transparent;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.skinLabel2.Location = new System.Drawing.Point(551, 230);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(42, 22);
            this.skinLabel2.TabIndex = 3;
            this.skinLabel2.Text = "密码";
            // 
            // Phone
            // 
            this.Phone.BackColor = System.Drawing.Color.Transparent;
            this.Phone.DownBack = null;
            this.Phone.Icon = ((System.Drawing.Image)(resources.GetObject("Phone.Icon")));
            this.Phone.IconIsButton = false;
            this.Phone.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.Phone.IsPasswordChat = '\0';
            this.Phone.IsSystemPasswordChar = false;
            this.Phone.Lines = new string[0];
            this.Phone.Location = new System.Drawing.Point(362, 161);
            this.Phone.Margin = new System.Windows.Forms.Padding(0);
            this.Phone.MaxLength = 32767;
            this.Phone.MinimumSize = new System.Drawing.Size(28, 28);
            this.Phone.MouseBack = null;
            this.Phone.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.Phone.Multiline = true;
            this.Phone.Name = "Phone";
            this.Phone.NormlBack = null;
            this.Phone.Padding = new System.Windows.Forms.Padding(5, 5, 28, 5);
            this.Phone.ReadOnly = false;
            this.Phone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Phone.Size = new System.Drawing.Size(185, 32);
            // 
            // 
            // 
            this.Phone.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Phone.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Phone.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Phone.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.Phone.SkinTxt.Multiline = true;
            this.Phone.SkinTxt.Name = "BaseText";
            this.Phone.SkinTxt.Size = new System.Drawing.Size(152, 22);
            this.Phone.SkinTxt.TabIndex = 0;
            this.Phone.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Phone.SkinTxt.WaterText = "";
            this.Phone.SkinTxt.WordWrap = false;
            this.Phone.TabIndex = 4;
            this.Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Phone.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Phone.WaterText = "";
            this.Phone.WordWrap = false;
            // 
            // Pwd
            // 
            this.Pwd.BackColor = System.Drawing.Color.Transparent;
            this.Pwd.DownBack = null;
            this.Pwd.Icon = ((System.Drawing.Image)(resources.GetObject("Pwd.Icon")));
            this.Pwd.IconIsButton = false;
            this.Pwd.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.Pwd.IsPasswordChat = '*';
            this.Pwd.IsSystemPasswordChar = false;
            this.Pwd.Lines = new string[0];
            this.Pwd.Location = new System.Drawing.Point(362, 227);
            this.Pwd.Margin = new System.Windows.Forms.Padding(0);
            this.Pwd.MaxLength = 16;
            this.Pwd.MinimumSize = new System.Drawing.Size(28, 28);
            this.Pwd.MouseBack = null;
            this.Pwd.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.Pwd.Multiline = true;
            this.Pwd.Name = "Pwd";
            this.Pwd.NormlBack = null;
            this.Pwd.Padding = new System.Windows.Forms.Padding(5, 5, 28, 5);
            this.Pwd.ReadOnly = false;
            this.Pwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Pwd.Size = new System.Drawing.Size(185, 32);
            // 
            // 
            // 
            this.Pwd.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Pwd.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pwd.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Pwd.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.Pwd.SkinTxt.MaxLength = 16;
            this.Pwd.SkinTxt.Multiline = true;
            this.Pwd.SkinTxt.Name = "BaseText";
            this.Pwd.SkinTxt.PasswordChar = '*';
            this.Pwd.SkinTxt.Size = new System.Drawing.Size(152, 22);
            this.Pwd.SkinTxt.TabIndex = 0;
            this.Pwd.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Pwd.SkinTxt.WaterText = "";
            this.Pwd.SkinTxt.WordWrap = false;
            this.Pwd.TabIndex = 5;
            this.Pwd.TabStop = true;
            this.Pwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Pwd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Pwd.WaterText = "";
            this.Pwd.WordWrap = false;
            // 
            // skinLabel3
            // 
            this.skinLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.skinLabel3.BorderColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderSize = 0;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.skinLabel3.Location = new System.Drawing.Point(362, 285);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(85, 44);
            this.skinLabel3.TabIndex = 6;
            this.skinLabel3.Text = "登录";
            this.skinLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.skinLabel3.Click += new System.EventHandler(this.skinLabel3_Click);
            // 
            // skinLabel4
            // 
            this.skinLabel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.skinLabel4.BorderColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderSize = 0;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(459, 285);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(85, 44);
            this.skinLabel4.TabIndex = 7;
            this.skinLabel4.Text = "注册";
            this.skinLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.skinLabel4.Click += new System.EventHandler(this.skinLabel4_Click);
            // 
            // gifBox1
            // 
            this.gifBox1.BorderColor = System.Drawing.Color.Transparent;
            this.gifBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gifBox1.Image = ((System.Drawing.Image)(resources.GetObject("gifBox1.Image")));
            this.gifBox1.Location = new System.Drawing.Point(556, 285);
            this.gifBox1.Name = "gifBox1";
            this.gifBox1.Size = new System.Drawing.Size(76, 44);
            this.gifBox1.TabIndex = 8;
            this.gifBox1.Text = "gifBox1";
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton1.InnerBorderColor = System.Drawing.Color.Transparent;
            this.skinButton1.IsDrawBorder = false;
            this.skinButton1.Location = new System.Drawing.Point(0, 0);
            this.skinButton1.MouseBack = null;
            this.skinButton1.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(0, 0);
            this.skinButton1.TabIndex = 9;
            this.skinButton1.Text = "skinButton1";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Visible = false;
            this.skinButton1.Click += new System.EventHandler(this.skinLabel3_Click);
            // 
            // LoginPage
            // 
            this.AcceptButton = this.skinButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(654, 445);
            this.CloseBoxSize = new System.Drawing.Size(40, 40);
            this.CloseDownBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseDownBack")));
            this.CloseMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseMouseBack")));
            this.CloseNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseNormlBack")));
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.gifBox1);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.Pwd);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.EffectBack = System.Drawing.Color.LightGoldenrodYellow;
            this.EffectWidth = 3;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(654, 446);
            this.MiniDownBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniDownBack")));
            this.MiniMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniMouseBack")));
            this.MiniNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniNormlBack")));
            this.MiniSize = new System.Drawing.Size(40, 40);
            this.Name = "LoginPage";
            this.Text = "xilixili";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        public CCWin.SkinControl.SkinTextBox Phone;
        private CCWin.SkinControl.SkinTextBox Pwd;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.GifBox gifBox1;
        private CCWin.SkinControl.SkinButton skinButton1;
    }
}