
namespace Burgerownia.Winforms
{
    partial class Form_EditBurger
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
            this.ingredientsListBox = new System.Windows.Forms.ListBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ingredientsListBox
            // 
            this.ingredientsListBox.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ingredientsListBox.FormattingEnabled = true;
            this.ingredientsListBox.ItemHeight = 65;
            this.ingredientsListBox.Location = new System.Drawing.Point(12, 12);
            this.ingredientsListBox.Name = "ingredientsListBox";
            this.ingredientsListBox.Size = new System.Drawing.Size(417, 264);
            this.ingredientsListBox.TabIndex = 0;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(12, 292);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(186, 146);
            this.button_delete.TabIndex = 1;
            this.button_delete.Text = "usuń";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.Button_delete_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(448, 12);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(186, 146);
            this.button_Add.TabIndex = 2;
            this.button_Add.Text = "dodaj";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // Form_EditBurger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(27F, 65F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(648, 453);
            this.ControlBox = false;
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.ingredientsListBox);
            this.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form_EditBurger";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_EditBurger";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ingredientsListBox;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_Add;
    }
}