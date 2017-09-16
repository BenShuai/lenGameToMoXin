using System;
using System.Windows.Forms;
using baseDateTool;

namespace lenGameToMoXin
{
    /// <summary>
    /// 用户第一次注册时观看的游戏宣传的画面
    /// </summary>
    public partial class Zhu : Form
    {
        public Zhu()
        {
            InitializeComponent();
        }

        private void Zhu_Load(object sender, EventArgs e)
        {
            this.Cursor = Tool.myCursor;
            texiao();
        }
        int nums = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            nums++;
            if (nums == 17)
            {
                string str5 = Application.StartupPath;//获取启动了应用程序的可执行文件的路径，不包括可执行文件的名称。
                string pathHtml = str5 + "\\lib\\com.lenleicool.dateBase\\com.lztr\\prop\\Dos.html";
                wbFlash.Url = new Uri(pathHtml);
            }
            if (nums == 236)
            {
                texiao();
                this.Controls.Remove(wbFlash);//删除特效显示画面
                //进入角色创建窗体
                CrateGameEr cffem = new CrateGameEr();
                cffem.Show();
                timer1.Enabled = false;
                this.Visible = false;
            }
        }
        /// <summary>
        /// 将页面显示的内容改为特效字体的显示画面
        /// </summary>
        private void texiao()
        {
            string str5 = Application.StartupPath;//获取启动了应用程序的可执行文件的路径，不包括可执行文件的名称。
            string pathHtml = str5 + "\\lib\\com.lenleicool.dateBase\\FileHtm\\Dos.html";
            wbFlash.Url = new Uri(pathHtml);
        }
    }
}
