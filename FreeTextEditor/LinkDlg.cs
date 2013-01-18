using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FreeTextEditor
{
    public partial class LinkDlg : Form
    {
        private String hyperlink;

        public LinkDlg()
        {
            InitializeComponent();
        }

        public String Hyperlink
        {
            get
            {
                hyperlink = hyperdest.Text;
                return hyperlink;
            }
        }


        private void insertbtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
