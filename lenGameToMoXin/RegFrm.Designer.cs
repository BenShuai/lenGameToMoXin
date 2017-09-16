namespace lenGameToMoXin
{
    partial class RegFrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassQue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbIdMsg = new System.Windows.Forms.Label();
            this.lbPassMsg = new System.Windows.Forms.Label();
            this.lbPassQueMsg = new System.Windows.Forms.Label();
            this.lbNameMsg = new System.Windows.Forms.Label();
            this.lbBai = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(365, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(17, 17);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.Location = new System.Drawing.Point(167, 346);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(57, 21);
            this.btnOk.TabIndex = 1;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "账    号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "密    码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "姓    名";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtId.Location = new System.Drawing.Point(165, 87);
            this.txtId.MaxLength = 16;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(169, 29);
            this.txtId.TabIndex = 5;
            this.txtId.Leave += new System.EventHandler(this.txtId_Leave);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPass.Location = new System.Drawing.Point(165, 140);
            this.txtPass.MaxLength = 16;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(169, 29);
            this.txtPass.TabIndex = 6;
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(165, 242);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(169, 29);
            this.txtName.TabIndex = 8;
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // txtPassQue
            // 
            this.txtPassQue.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPassQue.Location = new System.Drawing.Point(165, 191);
            this.txtPassQue.MaxLength = 16;
            this.txtPassQue.Name = "txtPassQue";
            this.txtPassQue.PasswordChar = '*';
            this.txtPassQue.Size = new System.Drawing.Size(169, 29);
            this.txtPassQue.TabIndex = 7;
            this.txtPassQue.Leave += new System.EventHandler(this.txtPassQue_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(39, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "确认密码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(39, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "魔心用户注册";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(108, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 14);
            this.label6.TabIndex = 11;
            this.label6.Text = "琳战天软第一款桌面游戏";
            // 
            // lbIdMsg
            // 
            this.lbIdMsg.AutoSize = true;
            this.lbIdMsg.BackColor = System.Drawing.Color.Transparent;
            this.lbIdMsg.ForeColor = System.Drawing.Color.Red;
            this.lbIdMsg.Location = new System.Drawing.Point(165, 123);
            this.lbIdMsg.Name = "lbIdMsg";
            this.lbIdMsg.Size = new System.Drawing.Size(0, 12);
            this.lbIdMsg.TabIndex = 12;
            // 
            // lbPassMsg
            // 
            this.lbPassMsg.AutoSize = true;
            this.lbPassMsg.BackColor = System.Drawing.Color.Transparent;
            this.lbPassMsg.ForeColor = System.Drawing.Color.Red;
            this.lbPassMsg.Location = new System.Drawing.Point(165, 172);
            this.lbPassMsg.Name = "lbPassMsg";
            this.lbPassMsg.Size = new System.Drawing.Size(0, 12);
            this.lbPassMsg.TabIndex = 13;
            // 
            // lbPassQueMsg
            // 
            this.lbPassQueMsg.AutoSize = true;
            this.lbPassQueMsg.BackColor = System.Drawing.Color.Transparent;
            this.lbPassQueMsg.ForeColor = System.Drawing.Color.Red;
            this.lbPassQueMsg.Location = new System.Drawing.Point(165, 227);
            this.lbPassQueMsg.Name = "lbPassQueMsg";
            this.lbPassQueMsg.Size = new System.Drawing.Size(0, 12);
            this.lbPassQueMsg.TabIndex = 14;
            // 
            // lbNameMsg
            // 
            this.lbNameMsg.AutoSize = true;
            this.lbNameMsg.BackColor = System.Drawing.Color.Transparent;
            this.lbNameMsg.ForeColor = System.Drawing.Color.Red;
            this.lbNameMsg.Location = new System.Drawing.Point(165, 274);
            this.lbNameMsg.Name = "lbNameMsg";
            this.lbNameMsg.Size = new System.Drawing.Size(0, 12);
            this.lbNameMsg.TabIndex = 15;
            // 
            // lbBai
            // 
            this.lbBai.AutoSize = true;
            this.lbBai.BackColor = System.Drawing.Color.Transparent;
            this.lbBai.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbBai.ForeColor = System.Drawing.Color.Red;
            this.lbBai.Location = new System.Drawing.Point(99, 308);
            this.lbBai.Name = "lbBai";
            this.lbBai.Size = new System.Drawing.Size(190, 19);
            this.lbBai.TabIndex = 16;
            this.lbBai.Text = "注册失败,请重新注册";
            this.lbBai.Visible = false;
            // 
            // RegFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::lenGameToMoXin.Properties.Resources.msg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(390, 378);
            this.Controls.Add(this.lbBai);
            this.Controls.Add(this.lbNameMsg);
            this.Controls.Add(this.lbPassQueMsg);
            this.Controls.Add(this.lbPassMsg);
            this.Controls.Add(this.lbIdMsg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPassQue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "魔心_注册";
            this.Load += new System.EventHandler(this.RegFrm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegFrm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassQue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbIdMsg;
        private System.Windows.Forms.Label lbPassMsg;
        private System.Windows.Forms.Label lbPassQueMsg;
        private System.Windows.Forms.Label lbNameMsg;
        private System.Windows.Forms.Label lbBai;
    }
}