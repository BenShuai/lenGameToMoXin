namespace lenGameToMoXin
{
    partial class XuanGameEr
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
            this.panMan1 = new System.Windows.Forms.Panel();
            this.panMan2 = new System.Windows.Forms.Panel();
            this.panMan3 = new System.Windows.Forms.Panel();
            this.panMan4 = new System.Windows.Forms.Panel();
            this.panName = new System.Windows.Forms.Panel();
            this.lbGameName = new System.Windows.Forms.Label();
            this.panClose = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panStart = new System.Windows.Forms.Panel();
            this.lbStart = new System.Windows.Forms.Label();
            this.panCreategame = new System.Windows.Forms.Panel();
            this.panDelPan2 = new System.Windows.Forms.Panel();
            this.panDelPan3 = new System.Windows.Forms.Panel();
            this.panDelPan4 = new System.Windows.Forms.Panel();
            this.panName.SuspendLayout();
            this.panClose.SuspendLayout();
            this.panStart.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMan1
            // 
            this.panMan1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panMan1.BackColor = System.Drawing.Color.Transparent;
            this.panMan1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panMan1.Location = new System.Drawing.Point(73, 158);
            this.panMan1.Name = "panMan1";
            this.panMan1.Size = new System.Drawing.Size(162, 184);
            this.panMan1.TabIndex = 0;
            this.panMan1.Click += new System.EventHandler(this.panMan1_Click);
            // 
            // panMan2
            // 
            this.panMan2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panMan2.BackColor = System.Drawing.Color.Transparent;
            this.panMan2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panMan2.Location = new System.Drawing.Point(258, 158);
            this.panMan2.Name = "panMan2";
            this.panMan2.Size = new System.Drawing.Size(162, 184);
            this.panMan2.TabIndex = 1;
            this.panMan2.Click += new System.EventHandler(this.panMan2_Click);
            // 
            // panMan3
            // 
            this.panMan3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panMan3.BackColor = System.Drawing.Color.Transparent;
            this.panMan3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panMan3.Location = new System.Drawing.Point(442, 158);
            this.panMan3.Name = "panMan3";
            this.panMan3.Size = new System.Drawing.Size(162, 184);
            this.panMan3.TabIndex = 1;
            this.panMan3.Click += new System.EventHandler(this.panMan3_Click);
            // 
            // panMan4
            // 
            this.panMan4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panMan4.BackColor = System.Drawing.Color.Transparent;
            this.panMan4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panMan4.Location = new System.Drawing.Point(628, 158);
            this.panMan4.Name = "panMan4";
            this.panMan4.Size = new System.Drawing.Size(162, 184);
            this.panMan4.TabIndex = 1;
            this.panMan4.Click += new System.EventHandler(this.panMan4_Click);
            // 
            // panName
            // 
            this.panName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panName.BackColor = System.Drawing.Color.Transparent;
            this.panName.Controls.Add(this.lbGameName);
            this.panName.Location = new System.Drawing.Point(360, 80);
            this.panName.Name = "panName";
            this.panName.Size = new System.Drawing.Size(156, 23);
            this.panName.TabIndex = 2;
            // 
            // lbGameName
            // 
            this.lbGameName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGameName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbGameName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbGameName.Location = new System.Drawing.Point(2, 0);
            this.lbGameName.Name = "lbGameName";
            this.lbGameName.Size = new System.Drawing.Size(160, 23);
            this.lbGameName.TabIndex = 0;
            this.lbGameName.Text = "请选择游戏角色";
            this.lbGameName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panClose
            // 
            this.panClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panClose.BackColor = System.Drawing.Color.Transparent;
            this.panClose.BackgroundImage = global::lenGameToMoXin.Properties.Resources.btn1;
            this.panClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panClose.Controls.Add(this.label1);
            this.panClose.Location = new System.Drawing.Point(45, 421);
            this.panClose.Name = "panClose";
            this.panClose.Size = new System.Drawing.Size(82, 27);
            this.panClose.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "退  出";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // panStart
            // 
            this.panStart.BackColor = System.Drawing.Color.Transparent;
            this.panStart.BackgroundImage = global::lenGameToMoXin.Properties.Resources.btn1;
            this.panStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panStart.Controls.Add(this.lbStart);
            this.panStart.Location = new System.Drawing.Point(736, 420);
            this.panStart.Name = "panStart";
            this.panStart.Size = new System.Drawing.Size(85, 28);
            this.panStart.TabIndex = 4;
            // 
            // lbStart
            // 
            this.lbStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStart.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbStart.Location = new System.Drawing.Point(0, 0);
            this.lbStart.Name = "lbStart";
            this.lbStart.Size = new System.Drawing.Size(85, 28);
            this.lbStart.TabIndex = 0;
            this.lbStart.Text = "进入游戏";
            this.lbStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbStart.MouseLeave += new System.EventHandler(this.lbStart_MouseLeave);
            this.lbStart.Click += new System.EventHandler(this.lbStart_Click);
            this.lbStart.MouseEnter += new System.EventHandler(this.lbStart_MouseEnter);
            // 
            // panCreategame
            // 
            this.panCreategame.BackColor = System.Drawing.Color.Transparent;
            this.panCreategame.Location = new System.Drawing.Point(365, 395);
            this.panCreategame.Name = "panCreategame";
            this.panCreategame.Size = new System.Drawing.Size(131, 34);
            this.panCreategame.TabIndex = 5;
            this.panCreategame.Click += new System.EventHandler(this.panCreategame_Click);
            // 
            // panDelPan2
            // 
            this.panDelPan2.BackColor = System.Drawing.Color.Transparent;
            this.panDelPan2.Location = new System.Drawing.Point(384, 136);
            this.panDelPan2.Name = "panDelPan2";
            this.panDelPan2.Size = new System.Drawing.Size(23, 16);
            this.panDelPan2.TabIndex = 6;
            this.panDelPan2.Click += new System.EventHandler(this.panDelPan2_Click);
            // 
            // panDelPan3
            // 
            this.panDelPan3.BackColor = System.Drawing.Color.Transparent;
            this.panDelPan3.Location = new System.Drawing.Point(569, 136);
            this.panDelPan3.Name = "panDelPan3";
            this.panDelPan3.Size = new System.Drawing.Size(23, 16);
            this.panDelPan3.TabIndex = 7;
            this.panDelPan3.Click += new System.EventHandler(this.panDelPan3_Click);
            // 
            // panDelPan4
            // 
            this.panDelPan4.BackColor = System.Drawing.Color.Transparent;
            this.panDelPan4.Location = new System.Drawing.Point(753, 136);
            this.panDelPan4.Name = "panDelPan4";
            this.panDelPan4.Size = new System.Drawing.Size(23, 16);
            this.panDelPan4.TabIndex = 8;
            this.panDelPan4.Click += new System.EventHandler(this.panDelPan4_Click);
            // 
            // XuanGameEr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::lenGameToMoXin.Properties.Resources.home;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(864, 473);
            this.Controls.Add(this.panDelPan4);
            this.Controls.Add(this.panDelPan3);
            this.Controls.Add(this.panDelPan2);
            this.Controls.Add(this.panCreategame);
            this.Controls.Add(this.panStart);
            this.Controls.Add(this.panClose);
            this.Controls.Add(this.panName);
            this.Controls.Add(this.panMan4);
            this.Controls.Add(this.panMan3);
            this.Controls.Add(this.panMan2);
            this.Controls.Add(this.panMan1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XuanGameEr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "魔心_琳战天软游戏工作室";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.XuanGameEr_Load);
            this.panName.ResumeLayout(false);
            this.panClose.ResumeLayout(false);
            this.panStart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMan1;
        private System.Windows.Forms.Panel panMan2;
        private System.Windows.Forms.Panel panMan3;
        private System.Windows.Forms.Panel panMan4;
        private System.Windows.Forms.Panel panName;
        private System.Windows.Forms.Label lbGameName;
        private System.Windows.Forms.Panel panClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panStart;
        private System.Windows.Forms.Label lbStart;
        private System.Windows.Forms.Panel panCreategame;
        private System.Windows.Forms.Panel panDelPan2;
        private System.Windows.Forms.Panel panDelPan3;
        private System.Windows.Forms.Panel panDelPan4;
    }
}