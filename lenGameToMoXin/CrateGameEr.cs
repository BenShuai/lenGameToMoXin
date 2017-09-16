using System;
using System.Drawing;
using System.Windows.Forms;
using baseDateTool;
using System.Media;

namespace lenGameToMoXin
{
    public partial class CrateGameEr : Form
    {
        public CrateGameEr()
        {
            InitializeComponent();
        }
        public SoundPlayer sound;
        public void CrateGameEr_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            sound = new SoundPlayer(@"lib\\com.lenleicool.dateBase\\com.lztr\\prop\\Advertisment\\bdaaer.wav");
            sound.Play();
            this.Cursor = Tool.myCursor;
            int heBase = (this.Height - 200) / 2;
            //每个角色选择面板的显示宽度
            int Widthed = (this.Width-200)/4;
            //设置男1号的大小
            panNan1.Width = Widthed;
            double heed1 = Widthed * 1.28;
            panNan1.Height = (int)heed1;
            panNan1.Location = new Point(40, heBase - (panNan1.Height/2));
            //设置女1号的大小
            panNv1.Width = Widthed;
            double heed3 = Widthed * 1.65;
            panNv1.Height = (int)heed3;
            panNv1.Location = new Point(80 + Widthed , heBase - (panNv1.Height / 2));
            //设置女2号的大小
            panNv2.Width = Widthed;
            double heed4 = Widthed * 1.48;
            panNv2.Height = (int)heed4;
            panNv2.Location = new Point(120 + Widthed * 2, heBase - (panNv2.Height / 2));
            //设置男2号的大小
            panNan2.Width = Widthed;
            double heed2 = Widthed * 1.37;
            panNan2.Height = (int)heed2;
            panNan2.Location = new Point(160 + Widthed*3, heBase - (panNan2.Height / 2));
            //设置属性面板的位置
            panShuXing.Width = 500;
            panShuXing.Height=100;
            panShuXing.Location = new Point(this.Width / 2 - panShuXing.Width/2,this.Height-150);
            this.Visible = true;
        }
        int nums = 0;
        /// <summary>
        /// 让音乐循环播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timbase_Tick(object sender, EventArgs e)
        {
            if (nums % 39 == 0 && nums > 0)
            {
                sound.Play();
            }
            nums++;
        }
        /// <summary>
        /// 男一号面板鼠标悬停事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panNan1_MouseEnter(object sender, EventArgs e)
        {
            panNan1.BorderStyle = BorderStyle.Fixed3D;
            lbName.Text = "魔 修 ● 孙 系";
            lbJieShao.Text = "孙系魔修注重以提高自身存储魔力来提升自己的修为\r\n在任何时候不会受到环境的影响，随意的发出强大的魔法攻击\r\n极限受到自身魔力存储量的影响";
            xianPa();
        }
        /// <summary>
        /// 男一号面板鼠标离开事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panNan1_MouseLeave(object sender, EventArgs e)
        {
            panNan1.BorderStyle = BorderStyle.None;
        }
        /// <summary>
        /// 女一号面板鼠标悬停事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panNv1_MouseEnter(object sender, EventArgs e)
        {
            panNv1.BorderStyle = BorderStyle.Fixed3D;
            lbName.Text = "魔 修 ● 杨 系";
            lbJieShao.Text = "杨系魔修注重加强外界魔法控制能力,以自身对魔力的牵引引导周身的魔力\r\n在任何地方均可根据魔力的牵引力度发出强大的攻击\r\n极限受到所在环境魔力密度的影响";
            xianPa();
        }
        /// <summary>
        /// 女一号面板鼠标离开事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panNv1_MouseLeave(object sender, EventArgs e)
        {
            panNv1.BorderStyle = BorderStyle.None;
        }
        /// <summary>
        /// 女二号面板鼠标悬停事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panNv2_MouseEnter(object sender, EventArgs e)
        {
            panNv2.BorderStyle = BorderStyle.Fixed3D;
            lbName.Text = "武 修 ● 杨 系";
            lbJieShao.Text = "杨系武修注重提升攻击速度,攻击力量和对敌人弱点攻击的能力\r\n无论敌人是谁，在发现致命弱点时都有机会发出致命一击\r\n极限所受攻击太强悍时,防御力会降低";
            xianPa();
        }
        /// <summary>
        /// 女二号面板鼠标离开事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panNv2_MouseLeave(object sender, EventArgs e)
        {
            panNv2.BorderStyle = BorderStyle.None;
        }
        /// <summary>
        /// 男二号面板鼠标悬停事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panNan2_MouseEnter(object sender, EventArgs e)
        {
            panNan2.BorderStyle = BorderStyle.Fixed3D;
            lbName.Text = "武 修 ● 孙 系";
            lbJieShao.Text = "孙系武修注重提升攻击力量和身体的抗打击能力\r\n对敌与阵时,强悍的防御力和血量是保命的关键,强大的力量是杀敌的\r\n极限所承受攻击速度太快时,攻击力会降低";
            xianPa();
        }
        /// <summary>
        /// 男二号面板鼠标离开事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panNan2_MouseLeave(object sender, EventArgs e)
        {
            panNan2.BorderStyle = BorderStyle.None;
        }
        /// <summary>
        /// 让提示信息显示出来
        /// </summary>
        public void xianPa()
        {
            if (lbPa.Visible == false)
            {
                lbPa.Visible = true;
            }
        }
        /// <summary>
        /// 显示为角色取名的窗体
        /// </summary>
        public Boolean tanNameSave()
        {
            SaveGameErName sgnFrm = new SaveGameErName();
            sgnFrm.ShowDialog();
            if (Tool.gameer != null)
            {
                if (Tool.gameer.niName != "")
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// 用户选择男一号角色时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panNan1_DoubleClick(object sender, EventArgs e)
        {
            if (tanNameSave())
            {
                Tool.gameer.userId = Tool.user.userId;
                Tool.gameer.playerType = "nan1";
                Tool.gameer.grade = 0;
                Tool.gameer.experience = 0;
                Tool.gameer.HP = 200;
                Tool.gameer.MP = 500;
                Tool.gameer.attack = 25;
                Tool.gameer.defense = 20;
                Tool.gameer.thump = 3;
                Tool.gameer.ZXC = 0;
                Tool.gameer.qi = 0;
                ToIndexFrm();
            }
        }

        private void panNv1_DoubleClick(object sender, EventArgs e)
        {
            if (tanNameSave())
            {
                Tool.gameer.userId = Tool.user.userId;
                Tool.gameer.playerType = "nv1";
                Tool.gameer.grade = 0;
                Tool.gameer.experience = 0;
                Tool.gameer.HP = 200;
                Tool.gameer.MP = 350;
                Tool.gameer.attack = 25;
                Tool.gameer.defense = 20;
                Tool.gameer.thump = 3;
                Tool.gameer.ZXC = 0;
                Tool.gameer.qi = 0;
                ToIndexFrm();
            }
        }

        private void panNv2_DoubleClick(object sender, EventArgs e)
        {
            if (tanNameSave())
            {
                Tool.gameer.userId = Tool.user.userId;
                Tool.gameer.playerType = "nv2";
                Tool.gameer.grade = 0;
                Tool.gameer.experience = 0;
                Tool.gameer.HP = 500;
                Tool.gameer.MP = 200;
                Tool.gameer.attack = 20;
                Tool.gameer.defense = 20;
                Tool.gameer.thump = 3;
                Tool.gameer.ZXC = 0;
                Tool.gameer.qi = 0;
                ToIndexFrm();
            }
        }

        private void panNan2_DoubleClick(object sender, EventArgs e)
        {
            if (tanNameSave())
            {
                Tool.gameer.userId = Tool.user.userId;
                Tool.gameer.playerType = "nan2";
                Tool.gameer.grade = 0;
                Tool.gameer.experience = 0;
                Tool.gameer.HP = 500;
                Tool.gameer.MP = 200;
                Tool.gameer.attack = 20;
                Tool.gameer.defense = 20;
                Tool.gameer.thump = 3;
                Tool.gameer.ZXC = 0;
                Tool.gameer.qi = 0;
                ToIndexFrm();
            }
        }
        /// <summary>
        /// 将角色信息保存到数据库
        /// </summary>
        private void ToIndexFrm()
        {
            sound.Stop();
            Data_len.CreateGameEr(Tool.gameer);
            indexGame indGamFrm = new indexGame();
            indGamFrm.Show();
            timbase.Enabled = false;
            this.Visible = false;
        }
    }
}
