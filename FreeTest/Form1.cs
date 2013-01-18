using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FreeTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();




    /*        UserControl userCtrl = new UserControl1.UserControl1();
            UserControl userCtrl1 = new UserControl2.UserControl1();

            this.freeTabCtrl1.addFreeTab(userCtrl, "扫描");
            this.freeTabCtrl1.addFreeTab(userCtrl1, "时间");*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(freeTextEditor1.HtmlText);
        }
    }
}
