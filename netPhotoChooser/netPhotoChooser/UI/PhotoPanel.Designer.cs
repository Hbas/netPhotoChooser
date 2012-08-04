namespace netPhotoChooser.UI
{
    partial class PhotoPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.star1 = new netPhotoChooser.UI.Star();
            this.star2 = new netPhotoChooser.UI.Star();
            this.star3 = new netPhotoChooser.UI.Star();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Black;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(150, 150);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // star1
            // 
            this.star1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.star1.Location = new System.Drawing.Point(118, 0);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(32, 32);
            this.star1.TabIndex = 1;
            this.star1.Visible = false;
            // 
            // star2
            // 
            this.star2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.star2.Location = new System.Drawing.Point(85, 0);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(32, 32);
            this.star2.TabIndex = 2;
            this.star2.Visible = false;
            // 
            // star3
            // 
            this.star3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.star3.Location = new System.Drawing.Point(52, 0);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(32, 32);
            this.star3.TabIndex = 3;
            this.star3.Visible = false;
            // 
            // PhotoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.star3);
            this.Controls.Add(this.star2);
            this.Controls.Add(this.star1);
            this.Controls.Add(this.pictureBox);
            this.Name = "PhotoPanel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private Star star1;
        private Star star2;
        private Star star3;
    }
}
