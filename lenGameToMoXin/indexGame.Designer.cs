namespace lenGameToMoXin
{
    partial class indexGame
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
            this.panMap = new System.Windows.Forms.Panel();
            this.panZhu = new System.Windows.Forms.Panel();
            this.groupBoxXuan = new System.Windows.Forms.GroupBox();
            this.PanOk = new System.Windows.Forms.Panel();
            this.lbOk = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RdoLianJi = new System.Windows.Forms.RadioButton();
            this.RdoDanRen = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RdoDiYu = new System.Windows.Forms.RadioButton();
            this.RdoKunNan = new System.Windows.Forms.RadioButton();
            this.RdoPuTong = new System.Windows.Forms.RadioButton();
            this.RdoJianDan = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdoXu = new System.Windows.Forms.RadioButton();
            this.RdoYu = new System.Windows.Forms.RadioButton();
            this.RdoYao = new System.Windows.Forms.RadioButton();
            this.RdoFeng = new System.Windows.Forms.RadioButton();
            this.RdoHuang = new System.Windows.Forms.RadioButton();
            this.RdoQin = new System.Windows.Forms.RadioButton();
            this.RdoMap1 = new System.Windows.Forms.RadioButton();
            this.panTou = new System.Windows.Forms.Panel();
            this.picTou = new System.Windows.Forms.PictureBox();
            this.cmsTouXiang = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.XinXiTool = new System.Windows.Forms.ToolStripMenuItem();
            this.BaoGuoTool = new System.Windows.Forms.ToolStripMenuItem();
            this.ShopTool = new System.Windows.Forms.ToolStripMenuItem();
            this.JinYinTool = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTool = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeXingZou = new System.Windows.Forms.Timer(this.components);
            this.panZhu.SuspendLayout();
            this.groupBoxXuan.SuspendLayout();
            this.PanOk.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panTou.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTou)).BeginInit();
            this.cmsTouXiang.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMap
            // 
            this.panMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panMap.Location = new System.Drawing.Point(0, 0);
            this.panMap.Name = "panMap";
            this.panMap.Size = new System.Drawing.Size(965, 491);
            this.panMap.TabIndex = 0;
            this.panMap.Click += new System.EventHandler(this.panMap_Click);
            // 
            // panZhu
            // 
            this.panZhu.BackColor = System.Drawing.Color.Black;
            this.panZhu.Controls.Add(this.groupBoxXuan);
            this.panZhu.Controls.Add(this.panTou);
            this.panZhu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panZhu.Location = new System.Drawing.Point(0, 0);
            this.panZhu.Name = "panZhu";
            this.panZhu.Size = new System.Drawing.Size(957, 482);
            this.panZhu.TabIndex = 1;
            // 
            // groupBoxXuan
            // 
            this.groupBoxXuan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxXuan.BackColor = System.Drawing.Color.White;
            this.groupBoxXuan.Controls.Add(this.PanOk);
            this.groupBoxXuan.Controls.Add(this.groupBox3);
            this.groupBoxXuan.Controls.Add(this.groupBox2);
            this.groupBoxXuan.Controls.Add(this.groupBox1);
            this.groupBoxXuan.ForeColor = System.Drawing.Color.Red;
            this.groupBoxXuan.Location = new System.Drawing.Point(195, 134);
            this.groupBoxXuan.Name = "groupBoxXuan";
            this.groupBoxXuan.Size = new System.Drawing.Size(500, 260);
            this.groupBoxXuan.TabIndex = 1;
            this.groupBoxXuan.TabStop = false;
            this.groupBoxXuan.Text = "游戏选择";
            // 
            // PanOk
            // 
            this.PanOk.BackgroundImage = global::lenGameToMoXin.Properties.Resources.btn1;
            this.PanOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanOk.Controls.Add(this.lbOk);
            this.PanOk.Location = new System.Drawing.Point(210, 223);
            this.PanOk.Name = "PanOk";
            this.PanOk.Size = new System.Drawing.Size(83, 31);
            this.PanOk.TabIndex = 3;
            // 
            // lbOk
            // 
            this.lbOk.AutoSize = true;
            this.lbOk.BackColor = System.Drawing.Color.Transparent;
            this.lbOk.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbOk.ForeColor = System.Drawing.Color.White;
            this.lbOk.Location = new System.Drawing.Point(5, 7);
            this.lbOk.Name = "lbOk";
            this.lbOk.Size = new System.Drawing.Size(72, 16);
            this.lbOk.TabIndex = 0;
            this.lbOk.Text = "进入游戏";
            this.lbOk.Click += new System.EventHandler(this.lbOk_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RdoLianJi);
            this.groupBox3.Controls.Add(this.RdoDanRen);
            this.groupBox3.Location = new System.Drawing.Point(6, 165);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(488, 49);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "对战模式";
            // 
            // RdoLianJi
            // 
            this.RdoLianJi.AutoSize = true;
            this.RdoLianJi.ForeColor = System.Drawing.Color.Black;
            this.RdoLianJi.Location = new System.Drawing.Point(151, 20);
            this.RdoLianJi.Name = "RdoLianJi";
            this.RdoLianJi.Size = new System.Drawing.Size(47, 16);
            this.RdoLianJi.TabIndex = 5;
            this.RdoLianJi.Text = "生存";
            this.RdoLianJi.UseVisualStyleBackColor = true;
            // 
            // RdoDanRen
            // 
            this.RdoDanRen.AutoSize = true;
            this.RdoDanRen.Checked = true;
            this.RdoDanRen.ForeColor = System.Drawing.Color.Black;
            this.RdoDanRen.Location = new System.Drawing.Point(30, 20);
            this.RdoDanRen.Name = "RdoDanRen";
            this.RdoDanRen.Size = new System.Drawing.Size(47, 16);
            this.RdoDanRen.TabIndex = 4;
            this.RdoDanRen.TabStop = true;
            this.RdoDanRen.Text = "任务";
            this.RdoDanRen.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RdoDiYu);
            this.groupBox2.Controls.Add(this.RdoKunNan);
            this.groupBox2.Controls.Add(this.RdoPuTong);
            this.groupBox2.Controls.Add(this.RdoJianDan);
            this.groupBox2.Location = new System.Drawing.Point(6, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 51);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "请选择地图难度(难度越高,经验越多,怪物越强悍)";
            // 
            // RdoDiYu
            // 
            this.RdoDiYu.AutoSize = true;
            this.RdoDiYu.ForeColor = System.Drawing.Color.Black;
            this.RdoDiYu.Location = new System.Drawing.Point(407, 20);
            this.RdoDiYu.Name = "RdoDiYu";
            this.RdoDiYu.Size = new System.Drawing.Size(47, 16);
            this.RdoDiYu.TabIndex = 3;
            this.RdoDiYu.Text = "地狱";
            this.RdoDiYu.UseVisualStyleBackColor = true;
            // 
            // RdoKunNan
            // 
            this.RdoKunNan.AutoSize = true;
            this.RdoKunNan.ForeColor = System.Drawing.Color.Black;
            this.RdoKunNan.Location = new System.Drawing.Point(277, 20);
            this.RdoKunNan.Name = "RdoKunNan";
            this.RdoKunNan.Size = new System.Drawing.Size(47, 16);
            this.RdoKunNan.TabIndex = 2;
            this.RdoKunNan.Text = "困难";
            this.RdoKunNan.UseVisualStyleBackColor = true;
            // 
            // RdoPuTong
            // 
            this.RdoPuTong.AutoSize = true;
            this.RdoPuTong.ForeColor = System.Drawing.Color.Black;
            this.RdoPuTong.Location = new System.Drawing.Point(151, 20);
            this.RdoPuTong.Name = "RdoPuTong";
            this.RdoPuTong.Size = new System.Drawing.Size(47, 16);
            this.RdoPuTong.TabIndex = 1;
            this.RdoPuTong.Text = "普通";
            this.RdoPuTong.UseVisualStyleBackColor = true;
            // 
            // RdoJianDan
            // 
            this.RdoJianDan.AutoSize = true;
            this.RdoJianDan.Checked = true;
            this.RdoJianDan.ForeColor = System.Drawing.Color.Black;
            this.RdoJianDan.Location = new System.Drawing.Point(30, 20);
            this.RdoJianDan.Name = "RdoJianDan";
            this.RdoJianDan.Size = new System.Drawing.Size(47, 16);
            this.RdoJianDan.TabIndex = 0;
            this.RdoJianDan.TabStop = true;
            this.RdoJianDan.Text = "简单";
            this.RdoJianDan.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdoXu);
            this.groupBox1.Controls.Add(this.RdoYu);
            this.groupBox1.Controls.Add(this.RdoYao);
            this.groupBox1.Controls.Add(this.RdoFeng);
            this.groupBox1.Controls.Add(this.RdoHuang);
            this.groupBox1.Controls.Add(this.RdoQin);
            this.groupBox1.Controls.Add(this.RdoMap1);
            this.groupBox1.Location = new System.Drawing.Point(6, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "请选择地图";
            // 
            // RdoXu
            // 
            this.RdoXu.AutoSize = true;
            this.RdoXu.ForeColor = System.Drawing.Color.Black;
            this.RdoXu.Location = new System.Drawing.Point(253, 51);
            this.RdoXu.Name = "RdoXu";
            this.RdoXu.Size = new System.Drawing.Size(59, 16);
            this.RdoXu.TabIndex = 6;
            this.RdoXu.Text = "虚无界";
            this.RdoXu.UseVisualStyleBackColor = true;
            this.RdoXu.Visible = false;
            // 
            // RdoYu
            // 
            this.RdoYu.AutoSize = true;
            this.RdoYu.ForeColor = System.Drawing.Color.Black;
            this.RdoYu.Location = new System.Drawing.Point(109, 51);
            this.RdoYu.Name = "RdoYu";
            this.RdoYu.Size = new System.Drawing.Size(71, 16);
            this.RdoYu.TabIndex = 5;
            this.RdoYu.Text = "狱天之漠";
            this.RdoYu.UseVisualStyleBackColor = true;
            this.RdoYu.Visible = false;
            // 
            // RdoYao
            // 
            this.RdoYao.AutoSize = true;
            this.RdoYao.ForeColor = System.Drawing.Color.Black;
            this.RdoYao.Location = new System.Drawing.Point(6, 51);
            this.RdoYao.Name = "RdoYao";
            this.RdoYao.Size = new System.Drawing.Size(59, 16);
            this.RdoYao.TabIndex = 4;
            this.RdoYao.Text = "妖心城";
            this.RdoYao.UseVisualStyleBackColor = true;
            this.RdoYao.Visible = false;
            // 
            // RdoFeng
            // 
            this.RdoFeng.AutoSize = true;
            this.RdoFeng.ForeColor = System.Drawing.Color.Black;
            this.RdoFeng.Location = new System.Drawing.Point(397, 20);
            this.RdoFeng.Name = "RdoFeng";
            this.RdoFeng.Size = new System.Drawing.Size(47, 16);
            this.RdoFeng.TabIndex = 3;
            this.RdoFeng.Text = "酆都";
            this.RdoFeng.UseVisualStyleBackColor = true;
            this.RdoFeng.Visible = false;
            // 
            // RdoHuang
            // 
            this.RdoHuang.AutoSize = true;
            this.RdoHuang.ForeColor = System.Drawing.Color.Black;
            this.RdoHuang.Location = new System.Drawing.Point(253, 20);
            this.RdoHuang.Name = "RdoHuang";
            this.RdoHuang.Size = new System.Drawing.Size(71, 16);
            this.RdoHuang.TabIndex = 2;
            this.RdoHuang.Text = "皇城郊外";
            this.RdoHuang.UseVisualStyleBackColor = true;
            this.RdoHuang.Visible = false;
            // 
            // RdoQin
            // 
            this.RdoQin.AutoSize = true;
            this.RdoQin.ForeColor = System.Drawing.Color.Black;
            this.RdoQin.Location = new System.Drawing.Point(109, 20);
            this.RdoQin.Name = "RdoQin";
            this.RdoQin.Size = new System.Drawing.Size(71, 16);
            this.RdoQin.TabIndex = 1;
            this.RdoQin.Text = "青叶坪地";
            this.RdoQin.UseVisualStyleBackColor = true;
            this.RdoQin.Visible = false;
            // 
            // RdoMap1
            // 
            this.RdoMap1.AutoSize = true;
            this.RdoMap1.Checked = true;
            this.RdoMap1.ForeColor = System.Drawing.Color.Black;
            this.RdoMap1.Location = new System.Drawing.Point(6, 20);
            this.RdoMap1.Name = "RdoMap1";
            this.RdoMap1.Size = new System.Drawing.Size(47, 16);
            this.RdoMap1.TabIndex = 0;
            this.RdoMap1.TabStop = true;
            this.RdoMap1.Text = "村郊";
            this.RdoMap1.UseVisualStyleBackColor = true;
            // 
            // panTou
            // 
            this.panTou.BackgroundImage = global::lenGameToMoXin.Properties.Resources.Tou;
            this.panTou.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panTou.Controls.Add(this.picTou);
            this.panTou.Location = new System.Drawing.Point(5, 5);
            this.panTou.Name = "panTou";
            this.panTou.Size = new System.Drawing.Size(159, 81);
            this.panTou.TabIndex = 0;
            // 
            // picTou
            // 
            this.picTou.BackColor = System.Drawing.Color.Transparent;
            this.picTou.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTou.ContextMenuStrip = this.cmsTouXiang;
            this.picTou.Location = new System.Drawing.Point(21, 16);
            this.picTou.Name = "picTou";
            this.picTou.Size = new System.Drawing.Size(45, 45);
            this.picTou.TabIndex = 1;
            this.picTou.TabStop = false;
            // 
            // cmsTouXiang
            // 
            this.cmsTouXiang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.XinXiTool,
            this.BaoGuoTool,
            this.ShopTool,
            this.JinYinTool,
            this.exitTool});
            this.cmsTouXiang.Name = "cmsTouXiang";
            this.cmsTouXiang.Size = new System.Drawing.Size(149, 114);
            // 
            // XinXiTool
            // 
            this.XinXiTool.Name = "XinXiTool";
            this.XinXiTool.Size = new System.Drawing.Size(148, 22);
            this.XinXiTool.Text = "查看个人信息";
            // 
            // BaoGuoTool
            // 
            this.BaoGuoTool.Name = "BaoGuoTool";
            this.BaoGuoTool.Size = new System.Drawing.Size(148, 22);
            this.BaoGuoTool.Text = "包裹";
            // 
            // ShopTool
            // 
            this.ShopTool.Name = "ShopTool";
            this.ShopTool.Size = new System.Drawing.Size(148, 22);
            this.ShopTool.Text = "商店";
            // 
            // JinYinTool
            // 
            this.JinYinTool.Name = "JinYinTool";
            this.JinYinTool.Size = new System.Drawing.Size(148, 22);
            this.JinYinTool.Text = "静音";
            this.JinYinTool.Click += new System.EventHandler(this.JinYinTool_Click);
            // 
            // exitTool
            // 
            this.exitTool.Name = "exitTool";
            this.exitTool.Size = new System.Drawing.Size(148, 22);
            this.exitTool.Text = "退出";
            this.exitTool.Click += new System.EventHandler(this.exitTool_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeXingZou
            // 
            this.timeXingZou.Tick += new System.EventHandler(this.timeXingZou_Tick);
            // 
            // indexGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(957, 482);
            this.Controls.Add(this.panZhu);
            this.Controls.Add(this.panMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "indexGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "魔心_琳战天软游戏工作室";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.indexGame_Load);
            this.panZhu.ResumeLayout(false);
            this.groupBoxXuan.ResumeLayout(false);
            this.PanOk.ResumeLayout(false);
            this.PanOk.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panTou.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTou)).EndInit();
            this.cmsTouXiang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMap;
        private System.Windows.Forms.Panel panZhu;
        private System.Windows.Forms.Panel panTou;
        private System.Windows.Forms.PictureBox picTou;
        private System.Windows.Forms.ContextMenuStrip cmsTouXiang;
        private System.Windows.Forms.ToolStripMenuItem XinXiTool;
        private System.Windows.Forms.ToolStripMenuItem BaoGuoTool;
        private System.Windows.Forms.ToolStripMenuItem ShopTool;
        private System.Windows.Forms.ToolStripMenuItem exitTool;
        private System.Windows.Forms.GroupBox groupBoxXuan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdoMap1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RdoJianDan;
        private System.Windows.Forms.RadioButton RdoPuTong;
        private System.Windows.Forms.RadioButton RdoDiYu;
        private System.Windows.Forms.RadioButton RdoKunNan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RdoDanRen;
        private System.Windows.Forms.RadioButton RdoLianJi;
        private System.Windows.Forms.Panel PanOk;
        private System.Windows.Forms.Label lbOk;
        private System.Windows.Forms.ToolStripMenuItem JinYinTool;
        private System.Windows.Forms.RadioButton RdoQin;
        private System.Windows.Forms.RadioButton RdoHuang;
        private System.Windows.Forms.RadioButton RdoFeng;
        private System.Windows.Forms.RadioButton RdoYao;
        private System.Windows.Forms.RadioButton RdoYu;
        private System.Windows.Forms.RadioButton RdoXu;
        private System.Windows.Forms.Timer timeXingZou;

    }
}