using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using netPhotoChooser.Properties;

namespace netPhotoChooser.UI
{
    public partial class Star : UserControl
    {
        public const int WS_EX_TRANSPARENT = 0x20;

        public Star()
        {
            InitializeComponent();
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            pe.Graphics.DrawImage(Resources.star, 0, 0);
        }

        [Browsable(false)]
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= WS_EX_TRANSPARENT;
                return cp;
            }
        }

    }
}
