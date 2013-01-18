using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mshtml;

namespace FreeTextEditor
{
    public partial class FreeTextEditor : UserControl
    {
        private IHTMLDocument2 doc;
        private String html;
        private String text;


        public FreeTextEditor()
        {
            InitializeComponent();

            webBrowser1.DocumentText = "<html><body></body></html>";
            doc =webBrowser1.Document.DomDocument as IHTMLDocument2;
            doc.designMode = "On";

            //将默认的webBrowser的右键菜单替换掉
            webBrowser1.Document.ContextMenuShowing +=
               new HtmlElementEventHandler(Document_ContextMenuShowing);

            InitializeFont();

            timer1.Start();
        }

        public void Document_ContextMenuShowing(object sender, HtmlElementEventArgs e)
        {
            e.ReturnValue = false;

            copyitem.Enabled = doc.queryCommandEnabled("Copy");
            cutitem.Enabled = doc.queryCommandEnabled("Cut");
            deleteitem.Enabled = doc.queryCommandEnabled("Delete");
            pasteitem.Enabled = doc.queryCommandEnabled("Paste");
            cancelitem.Enabled = doc.queryCommandEnabled("Undo");

            contextMenuStrip1.Show(this, e.ClientMousePosition);
        }

        private void InitializeFont()
        {
            foreach (FontFamily fam in FontFamily.Families)
            {
                fontbox.Items.Add(fam.Name);
            }

            fontbox.TextChanged += new EventHandler(fontbox_TextChanged);

            fontbox.Text = "宋体";

            string[] fontsize = { "8","9","10","14","18","24","36"};

            for (int i = 0; i <= fontsize.Length-1; i++)
            {
                fontsizebox.Items.Add(fontsize[i]);
            }

            fontsizebox.TextChanged += new EventHandler(fontsizebox_TextChanged);

            fontsizebox.Text = fontsizebox.Items[0].ToString();
        }

        private void fontbox_TextChanged(object sender, EventArgs e)
        {
            String fontname = fontbox.Text.Trim();

            try
            {
                FontFamily font = new FontFamily(fontname);

                webBrowser1.Document.ExecCommand("FontName", false, font.Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show("输入Font不合法");
            }

        }

        private void fontsizebox_TextChanged(object sender, EventArgs e)
        {
            String fontsize = fontsizebox.Text.Trim();

            try
            {
                int size = int.Parse(fontsize);

                webBrowser1.Document.ExecCommand("FontSize", false, size.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("输入字体大小不合法!");
            }
            
        }

        public String HtmlText {

            get {
                return webBrowser1.Document.Body.InnerHtml;
            }
            set
            {
                webBrowser1.Document.Body.InnerHtml = value;
            }
        }

        public String InnerText {

            get {
                return webBrowser1.Document.Body.InnerText;
            }
            set {
                webBrowser1.Document.Body.InnerText = value;
            }
        }

        private void boldbtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.ExecCommand("Bold", false, null);
        }

        private void italicbtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.ExecCommand("Italic", false, null);
        }

        private void underlinebtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.ExecCommand("Underline", false, null);
        }

        private void fontcolorbtn_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {

                string colorstr =  string.Format("#{0:X2}{1:X2}{2:X2}", 
                    colorDlg.Color.R, colorDlg.Color.G, colorDlg.Color.B);

                webBrowser1.Document.ExecCommand("ForeColor", false, colorstr);
            }
        }

        private void numlinebtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.ExecCommand("InsertOrderedList", false, null);
        }

        private void bulletbtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.ExecCommand("InsertUnorderedList", false, null);
        }

        private void leftalignbtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.ExecCommand("JustifyLeft", false, null);
        }

        private void centeralignbtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.ExecCommand("JustifyCenter", false, null);
        }

        private void rightalignbtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.ExecCommand("JustifyRight", false, null);
        }

        private void justifiedbtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.ExecCommand("JustifyFull", false, null);
        }

        private void hyerlinkbtn_Click(object sender, EventArgs e)
        {
            LinkDlg linkDlg = new LinkDlg();

            if (linkDlg.ShowDialog() == DialogResult.OK)
            {
                webBrowser1.Document.ExecCommand("CreateLink", false, linkDlg.Hyperlink);
            }
        }

        private void imagebtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.ExecCommand("InsertImage", true, null);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //如果一切就绪 开始检查
            if (doc.readyState.ToLower() == "complete")
            { 
                //每100ms检查一次 SelectionText 如果是 则linkbutton enable
                if (doc.selection.type.ToLower() == "text")
                {
                    hyerlinkbtn.Enabled = true;
                }
                else
                {
                    hyerlinkbtn.Enabled = false;
                }
            }
        }

     /*   private void cutitem_Click(object sender, EventArgs e)
        {

        }

        private void copyitem_Click(object sender, EventArgs e)
        {

        }

        private void pasteitem_Click(object sender, EventArgs e)
        {

        }

        private void deleteitem_Click(object sender, EventArgs e)
        {

        }

        private void cancelitem_Click(object sender, EventArgs e)
        {

        }*/


        private void cutitem_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.ExecCommand("Cut", false, null);
        }

        private void copyitem_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.ExecCommand("Copy", false, null);
        }

        private void pasteitem_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.ExecCommand("Paste", false, null);
        }

        private void deleteitem_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.ExecCommand("Delete", false, null);
        }

        private void cancelitem_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.ExecCommand("Undo", false, null);
        } 


    }
}
