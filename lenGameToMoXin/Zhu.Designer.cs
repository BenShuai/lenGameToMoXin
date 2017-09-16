namespace lenGameToMoXin
{
    partial class Zhu
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.wbFlash = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // wbFlash
            // 
            this.wbFlash.AllowWebBrowserDrop = false;
            this.wbFlash.CausesValidation = false;
            this.wbFlash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbFlash.IsWebBrowserContextMenuEnabled = false;
            this.wbFlash.Location = new System.Drawing.Point(0, 0);
            this.wbFlash.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbFlash.Name = "wbFlash";
            this.wbFlash.ScrollBarsEnabled = false;
            this.wbFlash.Size = new System.Drawing.Size(978, 528);
            this.wbFlash.TabIndex = 0;
            this.wbFlash.WebBrowserShortcutsEnabled = false;
            // 
            // Zhu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::lenGameToMoXin.Properties.Resources.ManXuan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 528);
            this.Controls.Add(this.wbFlash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Zhu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "魔心_琳战天软游戏工作室";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Zhu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.WebBrowser wbFlash;
    }
}