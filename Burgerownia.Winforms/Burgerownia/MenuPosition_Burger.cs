using System;
using System.Drawing;
using System.Windows.Forms;
using Burgerownia.Back.Model;

namespace Burgerownia.Winforms
{
    public class MenuPosition_Burger : MenuPositionCustomControl
    {
        private Burger _burger;
        public MenuPosition_Burger(Burger burger)
            : base()
        {
            ListBox_for_Ingredients.ForeColor = Color.FromArgb(255, 40, 0);
            _burger = burger;
            TextBox_name.DataBindings.Add(new Binding("Text", _burger, "Name"));
            _burger.Ingredients.ForEach(b => ListBox_for_Ingredients.Items.Add(b));
        }

        internal void OnClick_EditBurger(object sender, EventArgs e)
        {
                Form_EditBurger editBurger = new Form_EditBurger(_burger.Ingredients);
                editBurger.ShowDialog();
                _burger.Ingredients = editBurger.ConfirmedIngredients;

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MenuPosition_Burger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "MenuPosition_Burger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
