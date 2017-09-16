namespace lenGameToMoXin
{
    partial class SaveGameErName
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
            this.label1 = new System.Windows.Forms.Label();
            this.panCose = new System.Windows.Forms.Panel();
            this.panOk = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请为你的游戏角色取名";
            // 
            // panCose
            // 
            this.panCose.BackColor = System.Drawing.Color.Transparent;
            this.panCose.Location = new System.Drawing.Point(263, 3);
            this.panCose.Name = "panCose";
            this.panCose.Size = new System.Drawing.Size(15, 15);
            this.panCose.TabIndex = 1;
            this.panCose.Click += new System.EventHandler(this.panCose_Click);
            // 
            // panOk
            // 
            this.panOk.BackColor = System.Drawing.Color.Transparent;
            this.panOk.Location = new System.Drawing.Point(120, 240);
            this.panOk.Name = "panOk";
            this.panOk.Size = new System.Drawing.Size(43, 14);
            this.panOk.TabIndex = 2;
            this.panOk.Click += new System.EventHandler(this.panOk_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(24, 114);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(230, 29);
            this.txtName.TabIndex = 3;
            // 
            // lbMsg
            // 
            this.lbMsg.AutoSize = true;
            this.lbMsg.BackColor = System.Drawing.Color.Transparent;
            this.lbMsg.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMsg.ForeColor = System.Drawing.Color.Lime;
            this.lbMsg.Location = new System.Drawing.Point(82, 172);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(109, 20);
            this.lbMsg.TabIndex = 4;
            this.lbMsg.Text = "请输入名称";
            this.lbMsg.Visible = false;
            // 
            // SaveGameErName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::lenGameToMoXin.Properties.Resources.msg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lbMsg);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.panOk);
            this.Controls.Add(this.panCose);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveGameErName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "魔心";
            this.Load += new System.EventHandler(this.SaveGameErName_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SaveGameErName_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panCose;
        private System.Windows.Forms.Panel panOk;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbMsg;
    }
}