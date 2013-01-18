using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FreePanel
{
    public partial class FreePanel : Panel
    {
        public FreePanel()
        {
            this.DoubleBuffered = true;

            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.ResizeRedraw, true);

            UpdateStyles();


            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var parms = base.CreateParams;
                parms.Style &= ~0x02000000;  // Turn off WS_CLIPCHILDREN
                return parms;
            }
        }

  /*      protected override void OnPaintBackground(PaintEventArgs e)
        {
            return;
        }*/


        protected override void OnPaint(PaintEventArgs e)
        {
            
            base.OnPaint(e);
        }


/*        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            this.DoubleBuffered = true;

            if (this.BackgroundImage != null)
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                e.Graphics.DrawImage(this.BackgroundImage, 
                        new System.Drawing.Rectangle(0, 0, this.Width, this.Height),
                            0, 0, this.BackgroundImage.Width, this.BackgroundImage.Height,
                                System.Drawing.GraphicsUnit.Pixel);

            }

            base.OnPaint(e);

        }*/

    }
}
