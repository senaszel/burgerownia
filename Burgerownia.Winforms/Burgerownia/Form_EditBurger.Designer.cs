
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
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Swap = new System.Windows.Forms.Button();
            this.button_Confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ingredientsListBox
            // 
            this.ingredientsListBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ingredientsListBox.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ingredientsListBox.FormattingEnabled = true;
            this.ingredientsListBox.ItemHeight = 54;
            this.ingredientsListBox.Location = new System.Drawing.Point(12, 12);
            this.ingredientsListBox.Name = "ingredientsListBox";
            this.ingredientsListBox.Size = new System.Drawing.Size(417, 274);
            this.ingredientsListBox.TabIndex = 0;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(12, 292);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(200, 145);
            this.button_Delete.TabIndex = 1;
            this.button_Delete.Text = "usuń";
            this.button_Delete.UseVisualStyleBackColor = true;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(445, 12);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(200, 145);
            this.button_Add.TabIndex = 2;
            this.button_Add.Text = "dodaj";
            this.button_Add.UseVisualStyleBackColor = true;
            // 
            // button_Swap
            // 
            this.button_Swap.Location = new System.Drawing.Point(229, 292);
            this.button_Swap.Name = "button_Swap";
            this.button_Swap.Size = new System.Drawing.Size(200, 145);
            this.button_Swap.TabIndex = 3;
            this.button_Swap.Text = "zamień";
            this.button_Swap.UseVisualStyleBackColor = true;
            // 
            // button_Confirm
            // 
            this.button_Confirm.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Confirm.Location = new System.Drawing.Point(445, 176);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(200, 262);
            this.button_Confirm.TabIndex = 4;
            this.button_Confirm.Text = "Jest\r\ndobrze\r\ntakiego\r\nchce";
            this.button_Confirm.UseVisualStyleBackColor = true;
            // 
            // Form_EditBurger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(27F, 65F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button_Confirm);
            this.Controls.Add(this.button_Swap);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.ingredientsListBox);
            this.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_EditBurger";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_EditBurger";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ingredientsListBox;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Swap;
        private System.Windows.Forms.Button button_Confirm;
    }
}