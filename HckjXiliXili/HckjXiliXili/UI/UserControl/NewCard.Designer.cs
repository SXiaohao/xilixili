namespace HckjXiliXili
{
    partial class NewCard
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCard));
            this.New_image = new CCWin.SkinControl.SkinPictureBox();
            this.New_name = new CCWin.SkinControl.SkinLabel();
            this.New_text = new CCWin.SkinControl.SkinTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.New_image)).BeginInit();
            this.SuspendLayout();
            // 
            // New_image
            // 
            this.New_image.BackColor = System.Drawing.Color.Transparent;
            this.New_image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("New_image.BackgroundImage")));
            this.New_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.New_image.Location = new System.Drawing.Point(-1, 0);
            this.New_image.Name = "New_image";
            this.New_image.Size = new System.Drawing.Size(262, 164);
            this.New_image.TabIndex = 0;
            this.New_image.TabStop = false;
            this.New_image.Click += new System.EventHandler(this.NewCard_Click);
            // 
            // New_name
            // 
            this.New_name.BackColor = System.Drawing.Color.Transparent;
            this.New_name.BorderColor = System.Drawing.Color.Transparent;
            this.New_name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.New_name.ForeColor = System.Drawing.Color.White;
            this.New_name.Location = new System.Drawing.Point(0, 167);
            this.New_name.Name = "New_name";
            this.New_name.Size = new System.Drawing.Size(262, 36);
            this.New_name.TabIndex = 1;
            this.New_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // New_text
            // 
            this.New_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(136)))));
            this.New_text.DownBack = null;
            this.New_text.Enabled = false;
            this.New_text.Icon = null;
            this.New_text.IconIsButton = false;
            this.New_text.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.New_text.IsPasswordChat = '\0';
            this.New_text.IsSystemPasswordChar = false;
            this.New_text.Lines = new string[] {
        "10月新番如期而至，大家期待已久的小埋第二季终于来临，药王幸平也待着后宫佳丽重归荧幕。还有许许多多的百合动画萌动来袭，注定又是一个不平凡的季节...."};
            this.New_text.Location = new System.Drawing.Point(-1, 206);
            this.New_text.Margin = new System.Windows.Forms.Padding(0);
            this.New_text.MaxLength = 32767;
            this.New_text.MinimumSize = new System.Drawing.Size(28, 28);
            this.New_text.MouseBack = null;
            this.New_text.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.New_text.Multiline = true;
            this.New_text.Name = "New_text";
            this.New_text.NormlBack = null;
            this.New_text.Padding = new System.Windows.Forms.Padding(5);
            this.New_text.ReadOnly = false;
            this.New_text.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.New_text.Size = new System.Drawing.Size(263, 150);
            // 
            // 
            // 
            this.New_text.SkinTxt.BackColor = System.Drawing.Color.White;
            this.New_text.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.New_text.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.New_text.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.New_text.SkinTxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.New_text.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.New_text.SkinTxt.Multiline = true;
            this.New_text.SkinTxt.Name = "BaseText";
            this.New_text.SkinTxt.Size = new System.Drawing.Size(253, 140);
            this.New_text.SkinTxt.TabIndex = 0;
            this.New_text.SkinTxt.Text = "10月新番如期而至，大家期待已久的小埋第二季终于来临，药王幸平也待着后宫佳丽重归荧幕。还有许许多多的百合动画萌动来袭，注定又是一个不平凡的季节....";
            this.New_text.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.New_text.SkinTxt.WaterColor = System.Drawing.Color.Transparent;
            this.New_text.SkinTxt.WaterText = "";
            this.New_text.TabIndex = 2;
            this.New_text.Text = "10月新番如期而至，大家期待已久的小埋第二季终于来临，药王幸平也待着后宫佳丽重归荧幕。还有许许多多的百合动画萌动来袭，注定又是一个不平凡的季节....";
            this.New_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.New_text.WaterColor = System.Drawing.Color.Transparent;
            this.New_text.WaterText = "";
            this.New_text.WordWrap = true;
            // 
            // NewCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(131)))), ((int)(((byte)(173)))));
            this.Controls.Add(this.New_text);
            this.Controls.Add(this.New_name);
            this.Controls.Add(this.New_image);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "NewCard";
            this.Size = new System.Drawing.Size(260, 355);
            this.Load += new System.EventHandler(this.NewCard_Load);
            this.Click += new System.EventHandler(this.NewCard_Click);
            ((System.ComponentModel.ISupportInitialize)(this.New_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPictureBox New_image;
        private CCWin.SkinControl.SkinLabel New_name;
        private CCWin.SkinControl.SkinTextBox New_text;
    }
}
