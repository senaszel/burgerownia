
namespace Burgerownia.Winforms
{
    partial class Form_ChooseIngredient
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
            this.allPossibleIngredientsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // allPossibleIngredientsListBox
            // 
            this.allPossibleIngredientsListBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.allPossibleIngredientsListBox.FormattingEnabled = true;
            this.allPossibleIngredientsListBox.ItemHeight = 23;
            this.allPossibleIngredientsListBox.Location = new System.Drawing.Point(31, 138);
            this.allPossibleIngredientsListBox.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.allPossibleIngredientsListBox.Name = "allPossibleIngredientsListBox";
            this.allPossibleIngredientsListBox.Size = new System.Drawing.Size(330, 418);
            this.allPossibleIngredientsListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 90);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose ingredient to \r\nadd to your burger";
            // 
            // Form_ChooseIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(384, 583);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.allPossibleIngredientsListBox);
            this.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ChooseIngredient";
            this.Opacity = 0.8D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ChooseIngredient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox allPossibleIngredientsListBox;
        private System.Windows.Forms.Label label1;
    }
}