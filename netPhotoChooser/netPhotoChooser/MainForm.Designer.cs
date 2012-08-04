namespace netPhotoChooser
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orMoreStarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orMoreStarsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.starsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.starsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.or1StarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upTo2StarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetRatingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.photoPanel = new netPhotoChooser.UI.PhotoPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.albumToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureToolStripMenuItem,
            this.configurationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.configureToolStripMenuItem.Text = "Open...";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.configurationToolStripMenuItem.Text = "Configuration...";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // albumToolStripMenuItem
            // 
            this.albumToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.resetRatingsToolStripMenuItem});
            this.albumToolStripMenuItem.Name = "albumToolStripMenuItem";
            this.albumToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.albumToolStripMenuItem.Text = "Album";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orMoreStarsToolStripMenuItem,
            this.orMoreStarsToolStripMenuItem1,
            this.starsToolStripMenuItem});
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // orMoreStarsToolStripMenuItem
            // 
            this.orMoreStarsToolStripMenuItem.Name = "orMoreStarsToolStripMenuItem";
            this.orMoreStarsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.orMoreStarsToolStripMenuItem.Text = "1 or more stars...";
            // 
            // orMoreStarsToolStripMenuItem1
            // 
            this.orMoreStarsToolStripMenuItem1.Name = "orMoreStarsToolStripMenuItem1";
            this.orMoreStarsToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.orMoreStarsToolStripMenuItem1.Text = "2 or more stars...";
            // 
            // starsToolStripMenuItem
            // 
            this.starsToolStripMenuItem.Name = "starsToolStripMenuItem";
            this.starsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.starsToolStripMenuItem.Text = "3 stars...";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.starsToolStripMenuItem1,
            this.or1StarsToolStripMenuItem,
            this.upTo2StarsToolStripMenuItem});
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // starsToolStripMenuItem1
            // 
            this.starsToolStripMenuItem1.Name = "starsToolStripMenuItem1";
            this.starsToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.starsToolStripMenuItem1.Text = "0 stars";
            // 
            // or1StarsToolStripMenuItem
            // 
            this.or1StarsToolStripMenuItem.Name = "or1StarsToolStripMenuItem";
            this.or1StarsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.or1StarsToolStripMenuItem.Text = "0 or 1 stars";
            this.or1StarsToolStripMenuItem.Click += new System.EventHandler(this.delete1StarsMenuItem_Click);
            // 
            // upTo2StarsToolStripMenuItem
            // 
            this.upTo2StarsToolStripMenuItem.Name = "upTo2StarsToolStripMenuItem";
            this.upTo2StarsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.upTo2StarsToolStripMenuItem.Text = "Up to 2 stars";
            // 
            // resetRatingsToolStripMenuItem
            // 
            this.resetRatingsToolStripMenuItem.Name = "resetRatingsToolStripMenuItem";
            this.resetRatingsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.resetRatingsToolStripMenuItem.Text = "Reset ratings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // controlsToolStripMenuItem
            // 
            this.controlsToolStripMenuItem.Name = "controlsToolStripMenuItem";
            this.controlsToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.controlsToolStripMenuItem.Text = "Controls";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // photoPanel
            // 
            this.photoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.photoPanel.Image = null;
            this.photoPanel.Location = new System.Drawing.Point(0, 24);
            this.photoPanel.Name = "photoPanel";
            this.photoPanel.Size = new System.Drawing.Size(284, 238);
            this.photoPanel.TabIndex = 1;
            this.photoPanel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.photoPanel_KeyPress);
            this.photoPanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.photoPanel_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.photoPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Photo Chooser";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orMoreStarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orMoreStarsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem starsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem starsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem or1StarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upTo2StarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetRatingsToolStripMenuItem;
        private UI.PhotoPanel photoPanel;
    }
}