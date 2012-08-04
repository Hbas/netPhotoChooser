using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace netPhotoChooser
{
    //TODO Rename some components
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }


        private void photoPanel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Rate(e.KeyChar);
        }

        private void Rate(char key)
        {
            switch (key)
            {
                case '0':
                case '\'':
                    photoPanel.Rate(0);
                    break;
                case '1':
                    photoPanel.Rate(1);
                    break;
                case '2':
                    photoPanel.Rate(2);
                    break;
                case '3':
                    photoPanel.Rate(3);
                    break;
            }
        }

        //TODO: Why this method is not called?
        private void photoPanel_MouseClick(object sender, MouseEventArgs e)
        {
            SwitchStyle();
        }
        
        private void SwitchStyle()
        {
            if (this.FormBorderStyle == FormBorderStyle.None)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                menuStrip1.Visible = true;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
                menuStrip1.Visible = false;
            }
        }


        private void delete1StarsMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void photoPanel_MouseCaptureChanged(object sender, EventArgs e)
        {

        }





    }
}
