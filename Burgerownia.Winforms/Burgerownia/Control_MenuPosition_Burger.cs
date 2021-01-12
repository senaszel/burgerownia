using System;
using System.Drawing;
using System.Windows.Forms;
using Burgerownia.Back.Model;

namespace Burgerownia.Winforms
{
    public class Control_MenuPosition_Burger : MenuPositionCustomControl
    {
        private Burger _burger;
        private BindingSource burgerSource;
        private BindingSource ingredientsSource;
        public Control_MenuPosition_Burger(Burger burger)
            : base()
        {
            ListBox_for_Ingredients.ForeColor = Color.FromArgb(255, 40, 0);

            _burger = burger;
            burgerSource = new BindingSource();
            ingredientsSource = new BindingSource();
            burgerSource.DataSource = _burger;
            ingredientsSource.DataSource = _burger;

            TextBox_name.DataBindings.Add(new Binding("Text", burgerSource, "Name"));
            ListBox_for_Ingredients.DataSource = ingredientsSource;
            //ListBox_for_Ingredients.DisplayMember = "id";
            //ListBox_for_Ingredients.DisplayMember = "Ingredients";
        }

        internal void OnClick_EditBurger(object sender, EventArgs e)
        {
            Form_EditBurger editBurger = new Form_EditBurger(_burger.Ingredients);
            editBurger.ShowDialog();
            _burger.Ingredients = editBurger.ConfirmedIngredients;
        }



    }
}
