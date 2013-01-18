namespace FreeTextEditor
{
    partial class FreeTextEditor
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FreeTextEditor));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fontbox = new System.Windows.Forms.ToolStripComboBox();
            this.fontsizebox = new System.Windows.Forms.ToolStripComboBox();
            this.boldbtn = new System.Windows.Forms.ToolStripButton();
            this.italicbtn = new System.Windows.Forms.ToolStripButton();
            this.underlinebtn = new System.Windows.Forms.ToolStripButton();
            this.fontcolorbtn = new System.Windows.Forms.ToolStripButton();
            this.numlinebtn = new System.Windows.Forms.ToolStripButton();
            this.bulletbtn = new System.Windows.Forms.ToolStripButton();
            this.leftalignbtn = new System.Windows.Forms.ToolStripButton();
            this.centeralignbtn = new System.Windows.Forms.ToolStripButton();
            this.rightalignbtn = new System.Windows.Forms.ToolStripButton();
            this.justifiedbtn = new System.Windows.Forms.ToolStripButton();
            this.hyerlinkbtn = new System.Windows.Forms.ToolStripButton();
            this.imagebtn = new System.Windows.Forms.ToolStripButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutitem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyitem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteitem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteitem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelitem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontbox,
            this.fontsizebox,
            this.boldbtn,
            this.italicbtn,
            this.underlinebtn,
            this.fontcolorbtn,
            this.numlinebtn,
            this.bulletbtn,
            this.leftalignbtn,
            this.centeralignbtn,
            this.rightalignbtn,
            this.justifiedbtn,
            this.hyerlinkbtn,
            this.imagebtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(561, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // fontbox
            // 
            this.fontbox.Name = "fontbox";
            this.fontbox.Size = new System.Drawing.Size(120, 25);
            this.fontbox.ToolTipText = "字体";
            // 
            // fontsizebox
            // 
            this.fontsizebox.Name = "fontsizebox";
            this.fontsizebox.Size = new System.Drawing.Size(75, 25);
            this.fontsizebox.ToolTipText = "大小";
            // 
            // boldbtn
            // 
            this.boldbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldbtn.Image = ((System.Drawing.Image)(resources.GetObject("boldbtn.Image")));
            this.boldbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldbtn.Name = "boldbtn";
            this.boldbtn.Size = new System.Drawing.Size(23, 22);
            this.boldbtn.Text = "toolStripButton1";
            this.boldbtn.ToolTipText = "加粗";
            this.boldbtn.Click += new System.EventHandler(this.boldbtn_Click);
            // 
            // italicbtn
            // 
            this.italicbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italicbtn.Image = ((System.Drawing.Image)(resources.GetObject("italicbtn.Image")));
            this.italicbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicbtn.Name = "italicbtn";
            this.italicbtn.Size = new System.Drawing.Size(23, 22);
            this.italicbtn.Text = "倾斜";
            this.italicbtn.Click += new System.EventHandler(this.italicbtn_Click);
            // 
            // underlinebtn
            // 
            this.underlinebtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underlinebtn.Image = ((System.Drawing.Image)(resources.GetObject("underlinebtn.Image")));
            this.underlinebtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underlinebtn.Name = "underlinebtn";
            this.underlinebtn.Size = new System.Drawing.Size(23, 22);
            this.underlinebtn.Text = "下划线";
            this.underlinebtn.Click += new System.EventHandler(this.underlinebtn_Click);
            // 
            // fontcolorbtn
            // 
            this.fontcolorbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fontcolorbtn.Image = ((System.Drawing.Image)(resources.GetObject("fontcolorbtn.Image")));
            this.fontcolorbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fontcolorbtn.Name = "fontcolorbtn";
            this.fontcolorbtn.Size = new System.Drawing.Size(23, 22);
            this.fontcolorbtn.Text = "字体颜色";
            this.fontcolorbtn.Click += new System.EventHandler(this.fontcolorbtn_Click);
            // 
            // numlinebtn
            // 
            this.numlinebtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.numlinebtn.Image = ((System.Drawing.Image)(resources.GetObject("numlinebtn.Image")));
            this.numlinebtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.numlinebtn.Name = "numlinebtn";
            this.numlinebtn.Size = new System.Drawing.Size(23, 22);
            this.numlinebtn.Text = "编号";
            this.numlinebtn.Click += new System.EventHandler(this.numlinebtn_Click);
            // 
            // bulletbtn
            // 
            this.bulletbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bulletbtn.Image = ((System.Drawing.Image)(resources.GetObject("bulletbtn.Image")));
            this.bulletbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bulletbtn.Name = "bulletbtn";
            this.bulletbtn.Size = new System.Drawing.Size(23, 22);
            this.bulletbtn.Text = "项目符号";
            this.bulletbtn.Click += new System.EventHandler(this.bulletbtn_Click);
            // 
            // leftalignbtn
            // 
            this.leftalignbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.leftalignbtn.Image = ((System.Drawing.Image)(resources.GetObject("leftalignbtn.Image")));
            this.leftalignbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.leftalignbtn.Name = "leftalignbtn";
            this.leftalignbtn.Size = new System.Drawing.Size(23, 22);
            this.leftalignbtn.Text = "左对齐";
            this.leftalignbtn.Click += new System.EventHandler(this.leftalignbtn_Click);
            // 
            // centeralignbtn
            // 
            this.centeralignbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.centeralignbtn.Image = ((System.Drawing.Image)(resources.GetObject("centeralignbtn.Image")));
            this.centeralignbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.centeralignbtn.Name = "centeralignbtn";
            this.centeralignbtn.Size = new System.Drawing.Size(23, 22);
            this.centeralignbtn.Text = "居中";
            this.centeralignbtn.Click += new System.EventHandler(this.centeralignbtn_Click);
            // 
            // rightalignbtn
            // 
            this.rightalignbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rightalignbtn.Image = ((System.Drawing.Image)(resources.GetObject("rightalignbtn.Image")));
            this.rightalignbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rightalignbtn.Name = "rightalignbtn";
            this.rightalignbtn.Size = new System.Drawing.Size(23, 22);
            this.rightalignbtn.Text = "右对齐";
            this.rightalignbtn.Click += new System.EventHandler(this.rightalignbtn_Click);
            // 
            // justifiedbtn
            // 
            this.justifiedbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.justifiedbtn.Image = ((System.Drawing.Image)(resources.GetObject("justifiedbtn.Image")));
            this.justifiedbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.justifiedbtn.Name = "justifiedbtn";
            this.justifiedbtn.Size = new System.Drawing.Size(23, 22);
            this.justifiedbtn.Text = "两端对齐";
            this.justifiedbtn.Click += new System.EventHandler(this.justifiedbtn_Click);
            // 
            // hyerlinkbtn
            // 
            this.hyerlinkbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hyerlinkbtn.Image = ((System.Drawing.Image)(resources.GetObject("hyerlinkbtn.Image")));
            this.hyerlinkbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.hyerlinkbtn.Name = "hyerlinkbtn";
            this.hyerlinkbtn.Size = new System.Drawing.Size(23, 22);
            this.hyerlinkbtn.Text = "超链接";
            this.hyerlinkbtn.Click += new System.EventHandler(this.hyerlinkbtn_Click);
            // 
            // imagebtn
            // 
            this.imagebtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imagebtn.Image = ((System.Drawing.Image)(resources.GetObject("imagebtn.Image")));
            this.imagebtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imagebtn.Name = "imagebtn";
            this.imagebtn.Size = new System.Drawing.Size(23, 22);
            this.imagebtn.Text = "插入图片";
            this.imagebtn.Click += new System.EventHandler(this.imagebtn_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 25);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(561, 265);
            this.webBrowser1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutitem,
            this.copyitem,
            this.pasteitem,
            this.deleteitem,
            this.cancelitem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 136);
            // 
            // cutitem
            // 
            this.cutitem.Name = "cutitem";
            this.cutitem.Size = new System.Drawing.Size(152, 22);
            this.cutitem.Text = "剪切";
            this.cutitem.Click += new System.EventHandler(this.cutitem_Click);
            // 
            // copyitem
            // 
            this.copyitem.Name = "copyitem";
            this.copyitem.Size = new System.Drawing.Size(152, 22);
            this.copyitem.Text = "复制";
            this.copyitem.Click += new System.EventHandler(this.copyitem_Click);
            // 
            // pasteitem
            // 
            this.pasteitem.Name = "pasteitem";
            this.pasteitem.Size = new System.Drawing.Size(152, 22);
            this.pasteitem.Text = "粘贴";
            this.pasteitem.Click += new System.EventHandler(this.pasteitem_Click);
            // 
            // deleteitem
            // 
            this.deleteitem.Name = "deleteitem";
            this.deleteitem.Size = new System.Drawing.Size(152, 22);
            this.deleteitem.Text = "删除";
            this.deleteitem.Click += new System.EventHandler(this.deleteitem_Click);
            // 
            // cancelitem
            // 
            this.cancelitem.Name = "cancelitem";
            this.cancelitem.Size = new System.Drawing.Size(152, 22);
            this.cancelitem.Text = "撤销";
            this.cancelitem.Click += new System.EventHandler(this.cancelitem_Click);
            // 
            // FreeTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FreeTextEditor";
            this.Size = new System.Drawing.Size(561, 290);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton boldbtn;
        private System.Windows.Forms.ToolStripButton italicbtn;
        private System.Windows.Forms.ToolStripButton underlinebtn;
        private System.Windows.Forms.ToolStripButton fontcolorbtn;
        private System.Windows.Forms.ToolStripButton numlinebtn;
        private System.Windows.Forms.ToolStripButton bulletbtn;
        private System.Windows.Forms.ToolStripButton leftalignbtn;
        private System.Windows.Forms.ToolStripButton centeralignbtn;
        private System.Windows.Forms.ToolStripButton rightalignbtn;
        private System.Windows.Forms.ToolStripButton justifiedbtn;
        private System.Windows.Forms.ToolStripButton hyerlinkbtn;
        private System.Windows.Forms.ToolStripButton imagebtn;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripComboBox fontbox;
        private System.Windows.Forms.ToolStripComboBox fontsizebox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cutitem;
        private System.Windows.Forms.ToolStripMenuItem copyitem;
        private System.Windows.Forms.ToolStripMenuItem pasteitem;
        private System.Windows.Forms.ToolStripMenuItem deleteitem;
        private System.Windows.Forms.ToolStripMenuItem cancelitem;
    }
}
