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
    public partial class MsgTool : Form
    {
        public MsgTool(string msgTxt)
        {
            InitializeComponent();
            this.msg = msgTxt;
        }
        string msg;
        private void MsgTool_Load(object sender, EventArgs e)
        {
            this.Cursor = Tool.myCursor;
            PanColse.Cursor = Tool.myCursor1;
            panOk.Cursor = Tool.myCursor1;
            lbMsg.Text = msg;
        }

        private void PanColse_Click(object sender, EventArgs e)
        {
            Tool.flag = false;
            this.Close();
        }

        private void panOk_Click(object sender, EventArgs e)
        {
            Tool.flag = true;
            this.Close();
        }
    }
}
