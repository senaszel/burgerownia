namespace Burgerownia
{
    partial class Form_WelcomeScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_WelcomeScreen));
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.pictureBox_placeYourOrder_alaButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_placeYourOrder_alaButton)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.Image")));
            this.pictureBox_logo.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(649, 561);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            this.pictureBox_logo.Click += new System.EventHandler(this.pictureBox_logo_Click);
            // 
            // pictureBox_placeYourOrder_alaButton
            // 
            this.pictureBox_placeYourOrder_alaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_placeYourOrder_alaButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox_placeYourOrder_alaButton.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_placeYourOrder_alaButton.Image")));
            this.pictureBox_placeYourOrder_alaButton.Location = new System.Drawing.Point(0, 321);
            this.pictureBox_placeYourOrder_alaButton.Name = "pictureBox_placeYourOrder_alaButton";
            this.pictureBox_placeYourOrder_alaButton.Size = new System.Drawing.Size(649, 240);
            this.pictureBox_placeYourOrder_alaButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_placeYourOrder_alaButton.TabIndex = 0;
            this.pictureBox_placeYourOrder_alaButton.TabStop = false;
            this.pictureBox_placeYourOrder_alaButton.Click += new System.EventHandler(this.PictureBox_placeYourOrder_alaButton_Click);
            // 
            // Form_WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(649, 561);
            this.Controls.Add(this.pictureBox_placeYourOrder_alaButton);
            this.Controls.Add(this.pictureBox_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_WelcomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome Screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_placeYourOrder_alaButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.PictureBox pictureBox_placeYourOrder_alaButton;
    }
}

