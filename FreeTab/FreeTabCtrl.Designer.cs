namespace FreeTabCtrl
{
    partial class FreeTabCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FreeTabCtrl));
            this.TabPanel = new FreePanel.FreePanel();
            this.TabContent = new FreePanel.FreePanel();
            this.TabPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabPanel
            // 
            this.TabPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TabPanel.BackgroundImage")));
            this.TabPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TabPanel.Controls.Add(this.TabContent);
            this.TabPanel.Location = new System.Drawing.Point(3, 3);
            this.TabPanel.Name = "TabPanel";
            this.TabPanel.Size = new System.Drawing.Size(668, 402);
            this.TabPanel.TabIndex = 0;
            // 
            // TabContent
            // 
            this.TabContent.BackColor = System.Drawing.Color.White;
            this.TabContent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TabContent.BackgroundImage")));
            this.TabContent.Location = new System.Drawing.Point(0, 50);
            this.TabContent.Name = "TabContent";
            this.TabContent.Size = new System.Drawing.Size(668, 329);
            this.TabContent.TabIndex = 0;
            // 
            // FreeTabCtrl
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.TabPanel);
            this.Name = "FreeTabCtrl";
            this.Size = new System.Drawing.Size(654, 333);
            this.TabPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FreePanel.FreePanel TabPanel;
        private FreePanel.FreePanel TabContent;






    }
}
