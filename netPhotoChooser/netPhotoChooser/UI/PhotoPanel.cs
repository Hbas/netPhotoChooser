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
    public partial class PhotoPanel : UserControl
    {
        private List<Star> stars = new List<Star>();

        public PhotoPanel()
        {
            InitializeComponent();
            stars.Add(star1);
            stars.Add(star2);
            stars.Add(star3);
        }

        public Image Image
        {
            get
            {
                return pictureBox.Image;
            }
            set
            {
                pictureBox.Image = value;
            }
        }


        public void Rate(int numberOfStarsToShow)
        {
            foreach (var star in this.stars)
                star.Visible = false;

            for (int i = 0; i < numberOfStarsToShow; i++)
            {
                this.stars[i].Visible = true;
            }
            this.Refresh();
        }

    }
}
