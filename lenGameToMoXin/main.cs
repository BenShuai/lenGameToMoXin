using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using baseDateTool;

namespace lenGameToMoXin
{
    /// <summary>
    /// 过度窗体，加载用户的所有游戏角色信息
    /// </summary>
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 鼠标的样式
        /// </summary>
        /// <param name="lpFileName"></param>
        /// <returns></returns>
        private void main_Load(object sender, EventArgs e)
        {
            //界面上的普通鼠标样式
            this.Cursor = Tool.myCursor;
            
            int FW = this.Width;//窗体的宽度
            int FH = this.Height;//窗体的高度
            int TuW = picBg.Width;//背景图的宽度
            int TuH = picBg.Height;//背景图的高度
            picBg.Location = new Point(FW,(FH/2-TuH/2));
            int Ci = (FW - TuW) / 10;
            Gao = (FH - TuH) / Ci;
            
        }
        //背景图片高度增加的大小
        int Gao = 0;
        /// <summary>
        /// 时间控件，放大背景图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timBaseStart_Tick(object sender, EventArgs e)
        {
            if (picBg.Location.X > 0 && picBg.Location.Y > 0)
            {
                picBg.Width += 10;
                picBg.Height += Gao;
                picBg.Location = new Point(picBg.Location.X - 10, this.Height / 2 - picBg.Height / 2);
            }
            else
            {
                if (picBg.Location.Y <= 0 && picBg.Location.X > 0)
                {
                    picBg.Location = new Point(picBg.Location.X - 10, picBg.Location.Y);
                }
                if (picBg.Location.X <= 0 && picBg.Location.Y > 0)
                {
                    picBg.Location = new Point(picBg.Location.X, picBg.Location.Y - (Gao / 2) - 1);
                }
            }
            if (picBg.Location.Y <= 0 && picBg.Location.X <= 0)
            {
                this.BackgroundImage = picBg.BackgroundImage;
                this.Controls.Remove(picBg);

                picLogo.Location = new Point(this.Width / 2 - picLogo.Width / 2, this.Height / 2 - picLogo.Height / 2);
                picLogo.Visible = true;
                timeK.Enabled = true;
                timBaseStart.Enabled = false;
                timBaseStart = null;
            }
        }
        /// <summary>
        /// 下一个跳转的窗体
        /// </summary>
        int inde = 0;
        private void timeK_Tick(object sender, EventArgs e)
        {
            inde++;
            if (inde == 5)
            {
                //开始查找当前用户的游戏角色
                users user = Tool.user;
                List<gameEr> gameers = Data_len.queryGameEr(user.userId);
                if (gameers == null)//角色为空，当前用户还没有创建角色
                {
                    Zhu z = new Zhu();
                    z.Show();
                }
                else//当前用户有游戏角色
                {
                    Tool.gameers = gameers;
                    XuanGameEr xgeFrm = new XuanGameEr();
                    xgeFrm.Show();
                }
                timeK.Enabled = false;
                this.Visible = false;
            }
        }

    }
}
