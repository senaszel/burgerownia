
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.listBox_forIngredients = new System.Windows.Forms.ListBox();
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
            // listBox_forIngredients
            // 
            this.listBox_forIngredients.BackColor = System.Drawing.SystemColors.InfoText;
            this.listBox_forIngredients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_forIngredients.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox_forIngredients.FormattingEnabled = true;
            this.listBox_forIngredients.ItemHeight = 45;
            this.listBox_forIngredients.Location = new System.Drawing.Point(16, 104);
            this.listBox_forIngredients.Name = "listBox_forIngredients";
            this.listBox_forIngredients.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox_forIngredients.Size = new System.Drawing.Size(379, 180);
            this.listBox_forIngredients.TabIndex = 8;
            // 
            // MenuPositionCustomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.listBox_forIngredients);
            this.Controls.Add(this.pictureBox_For_Number);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.pictureBox_For_burgerPicture);
            this.Name = "MenuPositionCustomControl";
            this.Size = new System.Drawing.Size(700, 300);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_For_burgerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_For_Number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_For_burgerPicture;
        private System.Windows.Forms.PictureBox pictureBox_For_Number;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.ListBox listBox_forIngredients;
    }
}
