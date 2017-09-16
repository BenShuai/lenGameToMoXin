using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using baseDateTool;

namespace lenGameToMoXin
{
    public partial class RegFrm : Form
    {
        public RegFrm()
        {
            InitializeComponent();
        }

        //窗体的移动
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        private void RegFrm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x0112, 0xF012, 0);
        }
        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 鼠标的样式
        /// </summary>
        /// <param name="lpFileName"></param>
        /// <returns></returns>
        private void RegFrm_Load(object sender, EventArgs e)
        {
            //界面上的普通鼠标样式
            Cursor = Tool.myCursor;
            //鼠标悬停的样式
            panel1.Cursor = Tool.myCursor1;
            btnOk.Cursor = Tool.myCursor1;
            //输入框的鼠标样式
            txtName.Cursor = Tool.myCursor2;
            txtId.Cursor = Tool.myCursor2;
            txtPass.Cursor = Tool.myCursor2;
            txtPassQue.Cursor = Tool.myCursor2;
        }
        /// <summary>
        /// 验证用户输入的账号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtId_Leave(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() == "")
            {
                lbIdMsg.Text = "请输入账号";
            }
            else
            {
                if (!Data_len.qureyUserId(txtId.Text.Trim()))
                {
                    lbIdMsg.Text = "账号已注册，请更换账号";
                }
                else
                {
                    lbIdMsg.Text = "";
                }
            }
        }
        /// <summary>
        /// 验证密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text.Trim() == "")
            {
                lbPassMsg.Text = "请输入密码";
            }
            else
            {
                lbPassMsg.Text = "";
            }
        }
        /// <summary>
        /// 验证确认密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassQue_Leave(object sender, EventArgs e)
        {
            if (txtPassQue.Text.Trim() != txtPass.Text.Trim())
            {
                lbPassQueMsg.Text = "两次输入的密码不一致";
            }
            else
            {
                lbPassQueMsg.Text = "";
            }
        }
        /// <summary>
        /// 姓名验证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                lbNameMsg.Text = "请输入姓名";
            }
            else
            {
                lbNameMsg.Text = "";
            }
        }
        /// <summary>
        /// 确定注册的按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            txtId_Leave(sender, e);//判断账号的输入
            txtPass_Leave(sender, e);//判断密码的输入
            txtPassQue_Leave(sender, e);//判断确认密码的输入
            txtName_Leave(sender, e);//判断姓名的输入
            if (lbIdMsg.Text == "" && lbPassMsg.Text == "" && lbPassQueMsg.Text == "" && lbNameMsg.Text == "")
            {
                users user = new users(txtId.Text.Trim(), txtPass.Text.Trim(), txtName.Text.Trim());
                Data_len.RegBase(user);
                this.Close();//注册成功之后关闭注册窗体
            }
        }
    }
}
