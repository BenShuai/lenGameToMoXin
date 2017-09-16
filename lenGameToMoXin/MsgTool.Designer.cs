namespace lenGameToMoXin
{
    partial class MsgTool
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
            this.PanColse = new System.Windows.Forms.Panel();
            this.panOk = new System.Windows.Forms.Panel();
            this.lbMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PanColse
            // 
            this.PanColse.BackColor = System.Drawing.Color.Transparent;
            this.PanColse.Location = new System.Drawing.Point(204, 7);
            this.PanColse.Name = "PanColse";
            this.PanColse.Size = new System.Drawing.Size(16, 16);
            this.PanColse.TabIndex = 0;
            this.PanColse.Click += new System.EventHandler(this.PanColse_Click);
            // 
            // panOk
            // 
            this.panOk.BackColor = System.Drawing.Color.Transparent;
            this.panOk.Location = new System.Drawing.Point(86, 165);
            this.panOk.Name = "panOk";
            this.panOk.Size = new System.Drawing.Size(58, 20);
            this.panOk.TabIndex = 1;
            this.panOk.Click += new System.EventHandler(this.panOk_Click);
            // 
            // lbMsg
            // 
            this.lbMsg.BackColor = System.Drawing.Color.Transparent;
            this.lbMsg.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMsg.ForeColor = System.Drawing.Color.White;
            this.lbMsg.Location = new System.Drawing.Point(12, 43);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(205, 106);
            this.lbMsg.TabIndex = 2;
            this.lbMsg.Text = "提示";
            this.lbMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MsgTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::lenGameToMoXin.Properties.Resources.msgBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(229, 198);
            this.Controls.Add(this.lbMsg);
            this.Controls.Add(this.panOk);
            this.Controls.Add(this.PanColse);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MsgTool";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "魔心";
            this.Load += new System.EventHandler(this.MsgTool_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanColse;
        private System.Windows.Forms.Panel panOk;
        private System.Windows.Forms.Label lbMsg;
    }
}