namespace HckjXiliXili
{
    partial class CartoonPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartoonPage));
            this.skinFlowLayoutPanel1 = new CCWin.SkinControl.SkinFlowLayoutPanel();
            this.SuspendLayout();
            // 
            // skinFlowLayoutPanel1
            // 
            this.skinFlowLayoutPanel1.AutoScroll = true;
            this.skinFlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinFlowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinFlowLayoutPanel1.BackgroundImage")));
            this.skinFlowLayoutPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinFlowLayoutPanel1.DownBack = null;
            this.skinFlowLayoutPanel1.Location = new System.Drawing.Point(-1, 222);
            this.skinFlowLayoutPanel1.MouseBack = null;
            this.skinFlowLayoutPanel1.Name = "skinFlowLayoutPanel1";
            this.skinFlowLayoutPanel1.NormlBack = null;
            this.skinFlowLayoutPanel1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.skinFlowLayoutPanel1.Size = new System.Drawing.Size(1563, 780);
            this.skinFlowLayoutPanel1.TabIndex = 0;
            // 
            // CartoonPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(1560, 1000);
            this.CloseBoxSize = new System.Drawing.Size(40, 40);
            this.CloseDownBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseDownBack")));
            this.CloseMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseMouseBack")));
            this.CloseNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseNormlBack")));
            this.Controls.Add(this.skinFlowLayoutPanel1);
            this.EffectBack = System.Drawing.Color.LightCyan;
            this.EffectWidth = 3;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MiniDownBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniDownBack")));
            this.MiniMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniMouseBack")));
            this.MiniNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniNormlBack")));
            this.MiniSize = new System.Drawing.Size(40, 40);
            this.Name = "CartoonPage";
            this.Text = "xilixili";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.Load += new System.EventHandler(this.CartoonPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinFlowLayoutPanel skinFlowLayoutPanel1;
    }
}