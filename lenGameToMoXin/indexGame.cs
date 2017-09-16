using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using baseDateTool;
using System.Media;

namespace lenGameToMoXin
{
    public partial class indexGame : Form
    {
        public indexGame()
        {
            InitializeComponent();
        }
        public SoundPlayer sound;
        private void indexGame_Load(object sender, EventArgs e)
        {
            this.Cursor = Tool.myCursor;
            lbOk.Cursor = Tool.myCursor1;
            picTou.Cursor = Tool.myCursor1;
            cmsTouXiang.Cursor = Tool.myCursor1;
            sound = new SoundPlayer(@"lib\\com.lenleicool.dateBase\\com.lztr\\prop\\Advertisment\\bdaaer.wav");//背景音乐
            sound.Play();
            panZhu.Parent = this;
            panMap.Size = new Size(8000,8000);//地图
            try
            {
                picTou.BackgroundImage = Image.FromFile(@"lib\\men\\" + Tool.gameer.playerType + "Tou.png");//显示角色头像
            }
            catch (Exception ep) { }
            //计算选择框的显示位置
            groupBoxXuan.Location = new Point(this.Width / 2 - 250, this.Height / 2 - 110);

            //显示对应等级可以进入的地图
            if (Tool.gameer.grade >= 5)
            {
                RdoQin.Visible = true;
            }
            if (Tool.gameer.grade >= 10)
            {
                RdoHuang.Visible = true;
            }
            if (Tool.gameer.grade >= 20)
            {
                RdoFeng.Visible = true;
            }
            if (Tool.gameer.grade >= 30)
            {
                RdoYao.Visible = true;
            }
            if (Tool.gameer.grade >= 40)
            {
                RdoDiYu.Visible = true;
            }
            if (Tool.gameer.grade >= 50)
            {
                RdoXu.Visible = true;
            }

        }

        private void exitTool_Click(object sender, EventArgs e)//点击退出
        {
            ExitOkorNO frm = new ExitOkorNO();
            frm.ShowDialog();
        }
        int nums = 0;
        private void timer1_Tick(object sender, EventArgs e)//循环播放
        {
            if (nums == 39)
            {
                nums = 0;
                sound.Play();
            }
            nums++;
        }

        private void JinYinTool_Click(object sender, EventArgs e)//点击 "静音" 或 "播放音乐"
        {
            if (JinYinTool.Text.Equals("静音"))
            {
                JinYinTool.Text = "播放音乐";
                sound.Stop();
                nums = 0;
                timer1.Enabled = false;
            }
            else
            {
                JinYinTool.Text = "静音";
                sound.Play();
                timer1.Enabled = true;
            }
        }


        private void lbOk_Click(object sender, EventArgs e)//点击进入游戏
        {
            //判断地图
            if (RdoMap1.Checked)//村郊***********************************************************************************************************
            {
                panMap.BackgroundImage = Image.FromFile(@"lib\\com.lenleicool.dateBase\\com.lztr\\prop\\Advertisment\\MapList\\g.png");//设置地图
                //判断难度
                if (RdoJianDan.Checked)//简单
                {
                    List<Guai> guaiList = new List<Guai>();//创建100个初级小怪
                    for (int i = 0; i < 100; i++)
                    {
                        Panel guaiImg = new Panel();
                        Guai guai = new Guai("萨满", 3, 500, 200, 100, 0, 0);
                        
                        

                        guaiList.Add(guai);
                    }
                }
                else if (RdoPuTong.Checked)//普通
                {

                }
                else if (RdoKunNan.Checked)//困难
                {

                }
                else if (RdoDiYu.Checked)//地狱
                {

                }
            }
            else if (RdoQin.Checked)//青叶坪地***************************************************************************************************
            {
                panMap.BackgroundImage = Image.FromFile(@"lib\\com.lenleicool.dateBase\\com.lztr\\prop\\Advertisment\\MapList\\q.png");//设置地图
            }
            else if (RdoHuang.Checked)//皇城郊外*************************************************************************************************
            {
                panMap.BackgroundImage = Image.FromFile(@"lib\\com.lenleicool.dateBase\\com.lztr\\prop\\Advertisment\\MapList\\h.png");//设置地图
            }
            else if (RdoFeng.Checked)//酆都******************************************************************************************************
            {
                panMap.BackgroundImage = Image.FromFile(@"lib\\com.lenleicool.dateBase\\com.lztr\\prop\\Advertisment\\MapList\\f.png");//设置地图
            }
            else if (RdoYao.Checked)//妖心城*****************************************************************************************************
            {
                panMap.BackgroundImage = Image.FromFile(@"lib\\com.lenleicool.dateBase\\com.lztr\\prop\\Advertisment\\MapList\\y.png");//设置地图
            }
            else if (RdoYu.Checked)//狱天之漠****************************************************************************************************
            {
                panMap.BackgroundImage = Image.FromFile(@"lib\\com.lenleicool.dateBase\\com.lztr\\prop\\Advertisment\\MapList\\yu.png");//设置地图
            }
            else if (RdoXu.Checked)//虚无界******************************************************************************************************
            {
                panMap.BackgroundImage = Image.FromFile(@"lib\\com.lenleicool.dateBase\\com.lztr\\prop\\Advertisment\\MapList\\xu.png");//设置地图
            }

            

            //判断对战模式









            panTou.Parent = panMap;//设置头像的父级容器
            panZhu.Visible = false;//选择面板下面的黑色panle隐藏
        }

        private void panMap_Click(object sender, EventArgs e)//鼠标单机地图，人物行走
        {
            
        }

        int Ex = 0;//鼠标点击点的X坐标
        int Ey = 0;//鼠标点击点的Y坐标

        //控制人物向鼠标点击的地方行走
        private void timeXingZou_Tick(object sender, EventArgs e)
        {

        }






    }
}
