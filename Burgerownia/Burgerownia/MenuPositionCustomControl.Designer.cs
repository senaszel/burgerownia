
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
            this.pictureBox_For_burgerPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox_For_Number = new System.Windows.Forms.PictureBox();
            this.textBox_for_Ingredients = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_For_burgerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_For_Number)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_For_burgerPicture
            // 
            this.pictureBox_For_burgerPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_For_burgerPicture.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_For_burgerPicture.Image")));
            this.pictureBox_For_burgerPicture.Location = new System.Drawing.Point(410, 14);
            this.pictureBox_For_burgerPicture.Name = "pictureBox_For_burgerPicture";
            this.pictureBox_For_burgerPicture.Size = new System.Drawing.Size(255, 236);
            this.pictureBox_For_burgerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_For_burgerPicture.TabIndex = 4;
            this.pictureBox_For_burgerPicture.TabStop = false;
            // 
            // pictureBox_For_Number
            // 
            this.pictureBox_For_Number.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_For_Number.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_For_Number.Location = new System.Drawing.Point(568, 167);
            this.pictureBox_For_Number.Name = "pictureBox_For_Number";
            this.pictureBox_For_Number.Size = new System.Drawing.Size(122, 120);
            this.pictureBox_For_Number.TabIndex = 7;
            this.pictureBox_For_Number.TabStop = false;
            // 
            // textBox_for_Ingredients
            // 
            this.textBox_for_Ingredients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_for_Ingredients.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox_for_Ingredients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_for_Ingredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_for_Ingredients.ForeColor = System.Drawing.Color.Red;
            this.textBox_for_Ingredients.Location = new System.Drawing.Point(16, 110);
            this.textBox_for_Ingredients.MaxLength = 400;
            this.textBox_for_Ingredients.Multiline = true;
            this.textBox_for_Ingredients.Name = "textBox_for_Ingredients";
            this.textBox_for_Ingredients.Size = new System.Drawing.Size(379, 177);
            this.textBox_for_Ingredients.TabIndex = 6;
            this.textBox_for_Ingredients.Text = "- wymieniaj\r\n- skladniki\r\n- w tym\r\n- textboxie\r\n";
            this.textBox_for_Ingredients.WordWrap = false;
            // 
            // textBox_name
            // 
            this.textBox_name.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_name.ForeColor = System.Drawing.Color.Red;
            this.textBox_name.Location = new System.Drawing.Point(16, 33);
            this.textBox_name.MaxLength = 100;
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(379, 55);
            this.textBox_name.TabIndex = 5;
            this.textBox_name.Text = "MARIO";
            this.textBox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EachSingleItemCustomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.pictureBox_For_Number);
            this.Controls.Add(this.textBox_for_Ingredients);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.pictureBox_For_burgerPicture);
            this.Name = "EachSingleItemCustomControl";
            this.Size = new System.Drawing.Size(700, 300);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_For_burgerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_For_Number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_For_burgerPicture;
        private System.Windows.Forms.PictureBox pictureBox_For_Number;
        private System.Windows.Forms.TextBox textBox_for_Ingredients;
        private System.Windows.Forms.TextBox textBox_name;
    }
}
