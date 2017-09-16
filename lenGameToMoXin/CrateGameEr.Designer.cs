namespace lenGameToMoXin
{
    partial class CrateGameEr
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
            this.panNan1 = new System.Windows.Forms.Panel();
            this.panNv1 = new System.Windows.Forms.Panel();
            this.panNv2 = new System.Windows.Forms.Panel();
            this.panNan2 = new System.Windows.Forms.Panel();
            this.timbase = new System.Windows.Forms.Timer(this.components);
            this.panShuXing = new System.Windows.Forms.Panel();
            this.lbPa = new System.Windows.Forms.Label();
            this.lbJieShao = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.panShuXing.SuspendLayout();
            this.SuspendLayout();
            // 
            // panNan1
            // 
            this.panNan1.BackColor = System.Drawing.Color.Transparent;
            this.panNan1.BackgroundImage = global::lenGameToMoXin.Properties.Resources.nan1;
            this.panNan1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panNan1.Location = new System.Drawing.Point(61, 17);
            this.panNan1.Name = "panNan1";
            this.panNan1.Size = new System.Drawing.Size(200, 405);
            this.panNan1.TabIndex = 0;
            this.panNan1.DoubleClick += new System.EventHandler(this.panNan1_DoubleClick);
            this.panNan1.MouseLeave += new System.EventHandler(this.panNan1_MouseLeave);
            this.panNan1.MouseEnter += new System.EventHandler(this.panNan1_MouseEnter);
            // 
            // panNv1
            // 
            this.panNv1.BackColor = System.Drawing.Color.Transparent;
            this.panNv1.BackgroundImage = global::lenGameToMoXin.Properties.Resources.nv1;
            this.panNv1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panNv1.Location = new System.Drawing.Point(267, 17);
            this.panNv1.Name = "panNv1";
            this.panNv1.Size = new System.Drawing.Size(200, 405);
            this.panNv1.TabIndex = 1;
            this.panNv1.DoubleClick += new System.EventHandler(this.panNv1_DoubleClick);
            this.panNv1.MouseLeave += new System.EventHandler(this.panNv1_MouseLeave);
            this.panNv1.MouseEnter += new System.EventHandler(this.panNv1_MouseEnter);
            // 
            // panNv2
            // 
            this.panNv2.BackColor = System.Drawing.Color.Transparent;
            this.panNv2.BackgroundImage = global::lenGameToMoXin.Properties.Resources.nv2;
            this.panNv2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panNv2.Location = new System.Drawing.Point(473, 17);
            this.panNv2.Name = "panNv2";
            this.panNv2.Size = new System.Drawing.Size(200, 405);
            this.panNv2.TabIndex = 1;
            this.panNv2.DoubleClick += new System.EventHandler(this.panNv2_DoubleClick);
            this.panNv2.MouseLeave += new System.EventHandler(this.panNv2_MouseLeave);
            this.panNv2.MouseEnter += new System.EventHandler(this.panNv2_MouseEnter);
            // 
            // panNan2
            // 
            this.panNan2.BackColor = System.Drawing.Color.Transparent;
            this.panNan2.BackgroundImage = global::lenGameToMoXin.Properties.Resources.nan2;
            this.panNan2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panNan2.Location = new System.Drawing.Point(679, 17);
            this.panNan2.Name = "panNan2";
            this.panNan2.Size = new System.Drawing.Size(200, 405);
            this.panNan2.TabIndex = 1;
            this.panNan2.DoubleClick += new System.EventHandler(this.panNan2_DoubleClick);
            this.panNan2.MouseLeave += new System.EventHandler(this.panNan2_MouseLeave);
            this.panNan2.MouseEnter += new System.EventHandler(this.panNan2_MouseEnter);
            // 
            // timbase
            // 
            this.timbase.Enabled = true;
            this.timbase.Interval = 1000;
            this.timbase.Tick += new System.EventHandler(this.timbase_Tick);
            // 
            // panShuXing
            // 
            this.panShuXing.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panShuXing.BackColor = System.Drawing.Color.Transparent;
            this.panShuXing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panShuXing.Controls.Add(this.lbPa);
            this.panShuXing.Controls.Add(this.lbJieShao);
            this.panShuXing.Controls.Add(this.lbName);
            this.panShuXing.Location = new System.Drawing.Point(218, 437);
            this.panShuXing.Name = "panShuXing";
            this.panShuXing.Size = new System.Drawing.Size(500, 100);
            this.panShuXing.TabIndex = 2;
            // 
            // lbPa
            // 
            this.lbPa.AutoSize = true;
            this.lbPa.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPa.ForeColor = System.Drawing.Color.Yellow;
            this.lbPa.Location = new System.Drawing.Point(352, 7);
            this.lbPa.Name = "lbPa";
            this.lbPa.Size = new System.Drawing.Size(136, 16);
            this.lbPa.TabIndex = 2;
            this.lbPa.Text = "双击角色开始游戏";
            this.lbPa.Visible = false;
            // 
            // lbJieShao
            // 
            this.lbJieShao.AutoSize = true;
            this.lbJieShao.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbJieShao.ForeColor = System.Drawing.Color.White;
            this.lbJieShao.Location = new System.Drawing.Point(13, 37);
            this.lbJieShao.Name = "lbJieShao";
            this.lbJieShao.Size = new System.Drawing.Size(0, 16);
            this.lbJieShao.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbName.ForeColor = System.Drawing.Color.Red;
            this.lbName.Location = new System.Drawing.Point(12, 10);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 20);
            this.lbName.TabIndex = 0;
            // 
            // CrateGameEr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::lenGameToMoXin.Properties.Resources.ManXuan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 543);
            this.Controls.Add(this.panShuXing);
            this.Controls.Add(this.panNan2);
            this.Controls.Add(this.panNv2);
            this.Controls.Add(this.panNv1);
            this.Controls.Add(this.panNan1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CrateGameEr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "魔心_琳战天软游戏工作室";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CrateGameEr_Load);
            this.panShuXing.ResumeLayout(false);
            this.panShuXing.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panNan1;
        private System.Windows.Forms.Panel panNv1;
        private System.Windows.Forms.Panel panNv2;
        private System.Windows.Forms.Panel panNan2;
        private System.Windows.Forms.Timer timbase;
        private System.Windows.Forms.Panel panShuXing;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbJieShao;
        private System.Windows.Forms.Label lbPa;
    }
}