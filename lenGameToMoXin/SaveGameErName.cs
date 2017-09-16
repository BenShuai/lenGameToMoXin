using System;
using System.Windows.Forms;
using baseDateTool;
using System.Runtime.InteropServices;

namespace lenGameToMoXin
{
    /// <summary>
    /// 为角色取名的窗体
    /// </summary>
    public partial class SaveGameErName : Form
    {
        public SaveGameErName()
        {
            InitializeComponent();
        }
        //窗体的移动
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        private void SaveGameErName_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x0112, 0xF012, 0);
        }
        /// <summary>
        /// 加载鼠标样式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveGameErName_Load(object sender, EventArgs e)
        {
            this.Cursor = Tool.myCursor;
            panCose.Cursor = Tool.myCursor1;
            panOk.Cursor = Tool.myCursor1;
            txtName.Cursor = Tool.myCursor2;
        }
        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panCose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panOk_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                lbMsg.Text = "请输入名称";
                lbMsg.Visible = true;
            }
            else
            {
                if (Data_len.NiNameBaseTrue(txtName.Text.Trim()))
                {
                    Tool.gameer = new gameEr();
                    Tool.gameer.niName = txtName.Text.Trim();
                    this.Close();
                }
                else
                {
                    lbMsg.Text = "名称重复，请重新取名";
                    lbMsg.Visible = true;
                }
            }
        }




    }
}
