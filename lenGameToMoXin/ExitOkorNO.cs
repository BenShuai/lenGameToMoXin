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
    public partial class ExitOkorNO : Form
    {
        public ExitOkorNO()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)//不退出，关闭当前窗体
        {
            this.Close();
        }

        private void panel2_Click(object sender, EventArgs e)//确定退出
        {
            Application.Exit();
        }

        private void ExitOkorNO_Load(object sender, EventArgs e)
        {
            this.Cursor = Tool.myCursor;
            panel1.Cursor = Tool.myCursor1;
            panel2.Cursor = Tool.myCursor1;
        }


    }
}
