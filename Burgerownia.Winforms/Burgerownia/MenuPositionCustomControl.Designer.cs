
namespace Burgerownia.Winforms
{
    partial class MenuPositionCustomControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPositionCustomControl));
            this.pictureBox_BurgerPicture = new System.Windows.Forms.PictureBox();
            this.listBox_Ingredients = new System.Windows.Forms.ListBox();
            this.pictureBox_Numbers = new System.Windows.Forms.PictureBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BurgerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Numbers)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_BurgerPicture
            // 
            this.pictureBox_BurgerPicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_BurgerPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_BurgerPicture.BackgroundImage")));
            this.pictureBox_BurgerPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_BurgerPicture.Location = new System.Drawing.Point(461, 94);
            this.pictureBox_BurgerPicture.Name = "pictureBox_BurgerPicture";
            this.pictureBox_BurgerPicture.Size = new System.Drawing.Size(232, 139);
            this.pictureBox_BurgerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_BurgerPicture.TabIndex = 4;
            this.pictureBox_BurgerPicture.TabStop = false;
            // 
            // listBox_Ingredients
            // 
            this.listBox_Ingredients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_Ingredients.BackColor = System.Drawing.SystemColors.InfoText;
            this.listBox_Ingredients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_Ingredients.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox_Ingredients.FormattingEnabled = true;
            this.listBox_Ingredients.ItemHeight = 40;
            this.listBox_Ingredients.Location = new System.Drawing.Point(19, 94);
            this.listBox_Ingredients.Name = "listBox_Ingredients";
            this.listBox_Ingredients.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox_Ingredients.Size = new System.Drawing.Size(436, 200);
            this.listBox_Ingredients.TabIndex = 8;
            // 
            // pictureBox_Numbers
            // 
            this.pictureBox_Numbers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Numbers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Numbers.BackgroundImage")));
            this.pictureBox_Numbers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Numbers.Location = new System.Drawing.Point(580, 8);
            this.pictureBox_Numbers.Name = "pictureBox_Numbers";
            this.pictureBox_Numbers.Size = new System.Drawing.Size(113, 80);
            this.pictureBox_Numbers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Numbers.TabIndex = 9;
            this.pictureBox_Numbers.TabStop = false;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_Name.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Name.ForeColor = System.Drawing.Color.Red;
            this.textBox_Name.Location = new System.Drawing.Point(37, 18);
            this.textBox_Name.MaxLength = 100;
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(518, 55);
            this.textBox_Name.TabIndex = 5;
            this.textBox_Name.Text = "burger\'s name";
            // 
            // textBox_Price
            // 
            this.textBox_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Price.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox_Price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Price.ForeColor = System.Drawing.Color.Red;
            this.textBox_Price.Location = new System.Drawing.Point(461, 245);
            this.textBox_Price.MaxLength = 100;
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(232, 55);
            this.textBox_Price.TabIndex = 10;
            this.textBox_Price.Text = "price";
            this.textBox_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MenuPositionCustomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.pictureBox_Numbers);
            this.Controls.Add(this.listBox_Ingredients);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.pictureBox_BurgerPicture);
            this.Name = "MenuPositionCustomControl";
            this.Size = new System.Drawing.Size(700, 300);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BurgerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Numbers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_BurgerPicture;
        private System.Windows.Forms.ListBox listBox_Ingredients;
        private System.Windows.Forms.PictureBox pictureBox_Numbers;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Price;
    }
}
