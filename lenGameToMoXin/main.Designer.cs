namespace lenGameToMoXin
{
    partial class main
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
            this.timBaseStart = new System.Windows.Forms.Timer(this.components);
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picBg = new System.Windows.Forms.PictureBox();
            this.timeK = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBg)).BeginInit();
            this.SuspendLayout();
            // 
            // timBaseStart
            // 
            this.timBaseStart.Enabled = true;
            this.timBaseStart.Interval = 50;
            this.timBaseStart.Tick += new System.EventHandler(this.timBaseStart_Tick);
            // 
            // picLogo
            // 
            this.picLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::lenGameToMoXin.Properties.Resources.BGlogo;
            this.picLogo.Location = new System.Drawing.Point(156, 110);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(500, 300);
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            this.picLogo.Visible = false;
            // 
            // picBg
            // 
            this.picBg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picBg.BackgroundImage = global::lenGameToMoXin.Properties.Resources.mainBg;
            this.picBg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBg.Location = new System.Drawing.Point(799, 275);
            this.picBg.Name = "picBg";
            this.picBg.Size = new System.Drawing.Size(51, 30);
            this.picBg.TabIndex = 0;
            this.picBg.TabStop = false;
            // 
            // timeK
            // 
            this.timeK.Interval = 1000;
            this.timeK.Tick += new System.EventHandler(this.timeK_Tick);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.picBg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "魔心_琳战天软游戏工作室";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBg;
        private System.Windows.Forms.Timer timBaseStart;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Timer timeK;
    }
}