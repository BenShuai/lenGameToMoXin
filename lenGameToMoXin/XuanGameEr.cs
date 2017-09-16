using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using baseDateTool;

namespace lenGameToMoXin
{
    public partial class XuanGameEr : Form
    {
        public XuanGameEr()
        {
            InitializeComponent();
        }

        private void XuanGameEr_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Cursor = Tool.myCursor;
            panMan1.Cursor = Tool.myCursor1;
            panMan2.Cursor = Tool.myCursor1;
            panMan3.Cursor = Tool.myCursor1;
            panMan4.Cursor = Tool.myCursor1;
            label1.Cursor = Tool.myCursor1;
            lbStart.Cursor = Tool.myCursor1;
            panCreategame.Cursor = Tool.myCursor1;
            panDelPan2.Cursor = Tool.myCursor1;
            panDelPan3.Cursor = Tool.myCursor1;
            panDelPan4.Cursor = Tool.myCursor1;

            double yy = this.Height / 2.98;//角色面板的 Y 坐标
            double w=this.Width/5.32;
            int widthBg = (int)w;//角色面板的宽度
            double h = this.Height / 2.56;
            int heigthBg = (int)h;
            panMan1.Width = widthBg;
            panMan1.Height = heigthBg;
            double x1 = this.Width / 12;
            panMan1.Location = new Point((int)x1,(int)yy);
            panMan1.Cursor = Tool.myCursor1;

            panMan2.Width = widthBg;
            panMan2.Height = heigthBg;
            double x2 = this.Width / 3.34;
            panMan2.Location = new Point((int)x2, (int)yy);
            panMan2.Cursor = Tool.myCursor1;

            panMan3.Width = widthBg;
            panMan3.Height = heigthBg;
            double x3 = this.Width / 1.95;
            panMan3.Location = new Point((int)x3, (int)yy);
            panMan3.Cursor = Tool.myCursor1;

            panMan4.Width = widthBg;
            panMan4.Height = heigthBg;
            double x4 = this.Width / 1.38;
            panMan4.Location = new Point((int)x4, (int)yy);
            panMan4.Cursor = Tool.myCursor1;
            //选中角色的名称显示标签位置
            panName.Width = (int)((double)(this.Width / 7.556));
            panName.Height = (int)((double)(this.Height / 30.72));
            panName.Location = new Point((int)((double)(this.Width / 2.3)), (int)((double)(this.Height / 5.297)));
            //退出按钮的位置
            panClose.Width = (int)((double)(this.Width / 10.88));
            panClose.Height = (int)((double)(this.Height / 21.943));
            panClose.Location = new Point((int)((double)(this.Width / 18.1333)), (int)((double)(this.Height / 1.1195)));
            //开始按钮的位置
            panStart.Width = (int)((double)(this.Width / 10.88));
            panStart.Height = (int)((double)(this.Height / 21.943));
            panStart.Location = new Point((int)((double)(this.Width / 1.1724)), (int)((double)(this.Height / 1.1195)));
            //创建角色按钮的位置
            panCreategame.Width = (int)((double)(this.Width / 8.77));
            panCreategame.Height = (int)((double)(this.Height / 21.943));
            panCreategame.Location = new Point((int)((double)(this.Width / 2.27)), (int)((double)(this.Height / 1.18)));
            //第二个角色的删除按钮
            panDelPan2.Width = (int)((double)(this.Width / 48.571));
            panDelPan2.Height = (int)((double)(this.Height / 33.391));
            panDelPan2.Location = new Point((int)((double)(this.Width / 2.235)), (int)((double)(this.Height / 3.413)));
            //第三个角色的删除按钮
            panDelPan3.Width = (int)((double)(this.Width / 48.571));
            panDelPan3.Height = (int)((double)(this.Height / 33.391));
            panDelPan3.Location = new Point((int)((double)(this.Width / 1.51)), (int)((double)(this.Height / 3.413)));
            //第四个角色的删除按钮
            panDelPan4.Width = (int)((double)(this.Width / 48.571));
            panDelPan4.Height = (int)((double)(this.Height / 33.391));
            panDelPan4.Location = new Point((int)((double)(this.Width / 1.143)), (int)((double)(this.Height / 3.413)));
            XianGameEr();

            this.Visible = true;
        }
        /// <summary>
        /// 将角色信息显示到面板
        /// </summary>
        private void XianGameEr()
        {
            for (int i = 0; i < Tool.gameers.Count; i++)
            {
                if (i == 0)
                {
                    panMan1.Tag = Tool.gameers[0].niName;
                    panMan1.BackgroundImage = bgIma(Tool.gameers[0].playerType);

                    panMan2.Tag = null;
                    panMan2.BackgroundImage = null;

                    panMan3.Tag = null;
                    panMan3.BackgroundImage = null;

                    panMan4.Tag = null;
                    panMan4.BackgroundImage = null;
                }
                else if (i == 1)
                {
                    panMan2.Tag = Tool.gameers[1].niName;
                    panMan2.BackgroundImage = bgIma(Tool.gameers[1].playerType);
                }
                else if (i == 2)
                {
                    panMan3.Tag = Tool.gameers[2].niName;
                    panMan3.BackgroundImage = bgIma(Tool.gameers[2].playerType);
                }
                else if (i == 3)
                {
                    panMan4.Tag = Tool.gameers[3].niName;
                    panMan4.BackgroundImage = bgIma(Tool.gameers[3].playerType);
                }
            }
        }

        /// <summary>
        /// 返回角色的图像信息
        /// </summary>
        /// <param name="TypeName"></param>
        /// <returns></returns>
        public Image bgIma(string TypeName)
        {
            Image im = Image.FromFile(@"lib\\men\\nv1.png");
            if (TypeName.Equals("nv1"))
            {
                im = Image.FromFile(@"lib\\men\\nv1.png");
            }
            else if (TypeName.Equals("nv2"))
            {
                im = Image.FromFile(@"lib\\men\\nv2.png");
            }
            else if (TypeName.Equals("nan1"))
            {
                im = Image.FromFile(@"lib\\men\\nan1.png");
            }
            else if (TypeName.Equals("nan2"))
            {
                im = Image.FromFile(@"lib\\men\\nan2.png");
            }
            return im;
        }
        //退出标签的单击事件
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            panClose.BackgroundImage = Image.FromFile(@"lib\\com.lenleicool.dateBase\\FileHtm\\toSaveSouzen\\btn2.gif");
        }
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            panClose.BackgroundImage = lenGameToMoXin.Properties.Resources.btn1;
        }
        //进入游戏按钮的单击事件
        private void lbStart_Click(object sender, EventArgs e)
        {
            if (lbGameName.Text != "请选择游戏角色")
            {
                List<gameEr> games = Tool.gameers;
                foreach (gameEr ga in games)
                {
                    if (ga.niName == lbGameName.Text)
                    {
                        Tool.gameer = new gameEr();
                        Tool.gameer = ga;
                        break;
                    }
                }
                indexGame indgamFrm = new indexGame();
                indgamFrm.Show();
                this.Visible = false;
            }
            else
            {
                MsgTool ms = new MsgTool("请选择游戏角色");
                ms.ShowDialog();
            }
        }
        private void lbStart_MouseEnter(object sender, EventArgs e)
        {
            panStart.BackgroundImage = Image.FromFile(@"lib\\com.lenleicool.dateBase\\FileHtm\\toSaveSouzen\\btn2.gif");
        }
        private void lbStart_MouseLeave(object sender, EventArgs e)
        {
            panStart.BackgroundImage = lenGameToMoXin.Properties.Resources.btn1;
        }

        private void panMan1_Click(object sender, EventArgs e)
        {
            lbGameName.Text = panMan1.Tag.ToString();
        }

        private void panMan2_Click(object sender, EventArgs e)
        {
            if (panMan2.Tag!=null)
            {
                if (!panMan2.Tag.ToString().Equals(""))
                {
                    lbGameName.Text = panMan2.Tag.ToString();
                    //交换图片
                    Image im = panMan2.BackgroundImage;
                    panMan2.BackgroundImage = panMan1.BackgroundImage;
                    panMan1.BackgroundImage = im;
                    //交换tag
                    panMan2.Tag = panMan1.Tag;
                    panMan1.Tag = lbGameName.Text;
                }
            }
        }

        private void panMan3_Click(object sender, EventArgs e)
        {
            if (panMan3.Tag!=null)
            {
                if (!panMan3.Tag.ToString().Equals(""))
                {
                    lbGameName.Text = panMan3.Tag.ToString();
                    //交换图片
                    Image im = panMan3.BackgroundImage;
                    panMan3.BackgroundImage = panMan1.BackgroundImage;
                    panMan1.BackgroundImage = im;
                    //交换tag
                    panMan3.Tag = panMan1.Tag;
                    panMan1.Tag = lbGameName.Text;
                }
            }
        }

        private void panMan4_Click(object sender, EventArgs e)
        {
            if (panMan4.Tag!=null)
            {
                if (!panMan4.Tag.ToString().Equals(""))
                {
                    lbGameName.Text = panMan4.Tag.ToString();
                    //交换图片
                    Image im = panMan4.BackgroundImage;
                    panMan4.BackgroundImage = panMan1.BackgroundImage;
                    panMan1.BackgroundImage = im;
                    //交换tag
                    panMan4.Tag = panMan1.Tag;
                    panMan1.Tag = lbGameName.Text;
                }
            }
        }
        /// <summary>
        /// 创建新角色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panCreategame_Click(object sender, EventArgs e)
        {
            if (panMan4.Tag == null || panMan4.Tag.ToString() == "")
            {
                CrateGameEr frm = new CrateGameEr();
                frm.Show();
                this.Visible = false;
            }
            else
            {
                MsgTool msg = new MsgTool("最多只能有四个游戏角色\r\n请删除某些角色在做创建");
                msg.ShowDialog();
            }
        }
        //第二个删除按钮的单机事件
        private void panDelPan2_Click(object sender, EventArgs e)
        {
            if (panMan2.Tag != null)
            {
                if (panMan2.Tag.ToString() != "")
                {
                    MsgTool ms = new MsgTool("确定要删除当前角色吗？");
                    ms.ShowDialog();
                    if (Tool.flag)//开始删除当前角色
                    {
                        Data_len.DelGameEr(panMan2.Tag.ToString());
                        XianGameEr();
                    }
                }
            }
        }
        
        //第三个删除按钮的单机事件
        private void panDelPan3_Click(object sender, EventArgs e)
        {
            if (panMan3.Tag != null)
            {
                if (panMan3.Tag.ToString() != "")
                {
                    MsgTool ms = new MsgTool("确定要删除当前角色吗？");
                    ms.ShowDialog();
                    if (Tool.flag)//开始删除当前角色
                    {
                        Data_len.DelGameEr(panMan3.Tag.ToString());
                        XianGameEr();
                    }
                }
            }
        }
        //第四个删除按钮的单机事件
        private void panDelPan4_Click(object sender, EventArgs e)
        {
            if (panMan4.Tag != null)
            {
                if (panMan4.Tag.ToString() != "")
                {
                    MsgTool ms = new MsgTool("确定要删除当前角色吗？");
                    ms.ShowDialog();
                    if (Tool.flag)//开始删除当前角色
                    {
                        Data_len.DelGameEr(panMan4.Tag.ToString());
                        XianGameEr();
                    }
                }
            }
        }

    }
}
