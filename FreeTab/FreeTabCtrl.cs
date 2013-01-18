using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FreeTabCtrl
{
    public partial class FreeTabCtrl : UserControl
    {
        System.Collections.ArrayList tabArray;
        System.Collections.Hashtable tabHash;

        int normal_height ;
        int normal_Y ;

        //下面的六个属性可以改变Tab页的外观

        //两个固定的属性
        int top_padding = 2;
        int click_stretch = 2;
     
        //四个可以设置的属性
        Image hoverImage ;
        Image focusedImage ;
        Image normalImage ;
        int tab_btnpadding = 10;

        public FreeTabCtrl()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();

            InitializeComponent();

            if (normalImage == null)
            {
                hoverImage = FreeTab.Properties.Resources.tab_hover;
                normalImage = FreeTab.Properties.Resources.tab_normal;
                focusedImage = FreeTab.Properties.Resources.tab_pushed;
            }

            this.TabPanel.Location = this.Location;

            this.TabContent.Location = new Point(this.Location.X,
                  this.Location.Y + normalImage.Height + top_padding);


            tabArray = new System.Collections.ArrayList();
            tabHash = new System.Collections.Hashtable();
            normal_height = normalImage.Height - click_stretch*2;
            normal_Y = this.TabContent.Location.Y - normal_height;

            this.Resize += new EventHandler(FreeTabCtrl_Resize);

            //setActivate(0);

        }

        public void addFreeTab(UserControl userCtrl, String title)
        {
            int tabcnt = tabArray.Count;
            int X = this.TabContent.Location.X + (tabcnt + 1) * tab_btnpadding + tabcnt * normalImage.Width;
            int Y = normal_Y;

            MSButton.MSButton tabbtn = new MSButton.MSButton();

            tabbtn.Location = new Point(X, Y);

            tabbtn.Text = title;

            tabbtn.HoverImage = hoverImage;
            tabbtn.FocusedImage = focusedImage;
            tabbtn.NormalImage = normalImage;
            tabbtn.BackgroundImage = normalImage;

            tabbtn.Size = tabbtn.NormalImage.Size;
            tabbtn.ForeColor = Color.Black;
            tabbtn.TextAlign = ContentAlignment.MiddleCenter ;

            this.TabPanel.Controls.Add(tabbtn);

            tabbtn.Click += new EventHandler(tabbtn_Click);

            tabArray.Add(tabbtn);
            tabHash.Add(tabbtn, userCtrl);

            if (tabArray.Count == 1)
            {
                setActivate(0);
                //tabbtn_Click(tabArray[0], null);
            }
        }

        public void tabbtn_Click(object sender, EventArgs e)
        {
            MSButton.MSButton tabbtn = sender as MSButton.MSButton;

            tabbtn.Size = new Size(tabbtn.Size.Width, normal_height+click_stretch);
            tabbtn.Location = new Point(tabbtn.Location.X, normal_Y-click_stretch);

            for(int i = 0; i<= tabArray.Count-1; i++)
                if (tabArray[i] != sender)
                {
                    MSButton.MSButton btn = tabArray[i] as MSButton.MSButton;

                    btn.setClicked(false);

                    btn.Size = new Size(tabbtn.Size.Width, normal_height);
                    btn.Location = new Point(btn.Location.X, normal_Y );
                }

            UserControl userCtrl = tabHash[tabbtn] as UserControl;

            this.TabContent.Controls.Clear();

            this.TabContent.Visible = true;
            userCtrl.Show();
            this.TabContent.Controls.Add(userCtrl);
        }

        public void setActivate(int i)
        {
            MSButton.MSButton btn = tabArray[i] as MSButton.MSButton;

            btn.setClicked(true);
            tabbtn_Click(btn, null);
        }

        public void FreeTabCtrl_Resize(object sender, System.EventArgs e)
        { 

            this.TabPanel.Size = this.Size;

            this.TabContent.Size = new Size(this.Size.Width, this.Size.Height - normalImage.Height);
        }


        public int TabBtnPadding
        {
            get {
                return tab_btnpadding;
            }
            set {
                tab_btnpadding = value;
            }
        }

        public Image HoverImage {
            get {
                return hoverImage;
            }
            set {
                hoverImage = value;
            }
        }

        public Image NormalImage
        {
            get {
                return normalImage;
            }
            set {
                normalImage = value;
            }
        }

        public Image FocusedImage {
            get {
                return focusedImage;
            }
            set {
                focusedImage = value;
            }
        }

    }
}
