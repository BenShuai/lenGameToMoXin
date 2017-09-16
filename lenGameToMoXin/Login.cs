using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using baseDateTool;
using System.Reflection;

namespace lenGameToMoXin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        

        //窗体的移动
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x0112, 0xF012, 0);
        }
        /// <summary>
        /// 退出程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)//关闭程序
        {
            Application.Exit();
        }
        //关闭按钮的鼠标悬停事件
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.Location = new Point(pictureBox1.Location.X - 1, pictureBox1.Location.Y - 1);
        }
        //关闭按钮的鼠标离开事件
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(22, 22);
            pictureBox1.Location = new Point(pictureBox1.Location.X + 1, pictureBox1.Location.Y + 1);
        }

        
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegLink_Click(object sender, EventArgs e)
        {
            RegFrm rf = new RegFrm();
            rf.ShowDialog();
        }


        /// <summary>
        /// 鼠标的样式
        /// </summary>
        /// <param name="lpFileName"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        static extern IntPtr LoadCursorFromFile(string lpFileName);
        private void Login_Load(object sender, EventArgs e)
        {
            //界面上的普通鼠标样式
            Cursor myCursor = new Cursor(Cursor.Current.Handle);
            IntPtr colorCursorHandle = LoadCursorFromFile(@"lib/ani/basecur/1.cur");
            myCursor.GetType().InvokeMember("handle", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetField, null, myCursor, new Object[1] { colorCursorHandle });
            this.Cursor = myCursor;
            Tool.myCursor = myCursor;
            //鼠标悬停的样式
            Cursor myCursor1 = new Cursor(Cursor.Current.Handle);
            IntPtr colorCursorHandle1 = LoadCursorFromFile(@"lib/ani/basecur/Shou.cur");
            myCursor1.GetType().InvokeMember("handle", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetField, null, myCursor1, new Object[1] { colorCursorHandle1 });
            pictureBox1.Cursor = myCursor1;
            panStr.Cursor = myCursor1;
            RegLink.Cursor = myCursor1;
            panClear.Cursor = myCursor1;
            Tool.myCursor1 = myCursor1;
            //输入框的鼠标样式
            Cursor myCursor2 = new Cursor(Cursor.Current.Handle);
            IntPtr colorCursorHandle2 = LoadCursorFromFile(@"lib/ani/basecur/I.ani");
            myCursor2.GetType().InvokeMember("handle", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetField, null, myCursor2, new Object[1] { colorCursorHandle2 });
            txtName.Cursor = myCursor2;
            txtPassword.Cursor = myCursor2;
            Tool.myCursor2=myCursor2;
        }
        /// <summary>
        /// 窗体激活时，重新加载LOGO。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Activated(object sender, EventArgs e)
        {
            this.logopic.Image = lenGameToMoXin.Properties.Resources.logo;
        }
        /// <summary>
        /// 开始游戏  按钮的鼠标悬停事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panStr_MouseEnter(object sender, EventArgs e)
        {
            panStr.BackgroundImage = Image.FromFile(@"images/btnStr.png");
        }
        /// <summary>
        /// 开始游戏  按钮的鼠标离开事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panStr_MouseLeave(object sender, EventArgs e)
        {
            panStr.BackgroundImage = null;
        }
        /// <summary>
        /// 开始游戏  按钮的鼠标点击事件(登录)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panStr_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                lbMsg.Text = "请输入账号";
            }
            else if (txtPassword.Text.Trim() == "")
            {
                lbMsg.Text = "请输入密码";
            }
            else
            {
                users u = new users(txtName.Text.Trim(), txtPassword.Text.Trim(), "");
                users us = Data_len.login(u, lbMsg);
                if (us == null)
                {
                    if (lbMsg.Text != "您未注册，请先注册")
                    {
                        lbMsg.Text = "您的帐号或密码错误，请重新输入";
                    }
                }
                else
                {
                    Tool.user = us;
                    main m = new main();
                    m.Show();
                    this.Visible = false;
                }
            }
        }
        /// <summary>
        /// 清除 按钮的鼠标悬停事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panClear_MouseEnter(object sender, EventArgs e)
        {
            panClear.BackgroundImage = Image.FromFile(@"images/btnCle.png");
        }
        /// <summary>
        /// 清除 按钮的鼠标离开事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panClear_MouseLeave(object sender, EventArgs e)
        {
            panClear.BackgroundImage = null;
        }
        /// <summary>
        /// 清除按钮的单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPassword.Text = "";
        }








    }
}
