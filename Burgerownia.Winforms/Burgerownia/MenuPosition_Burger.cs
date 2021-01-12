using System;
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
            _burger = burger;
            TextBox_name.DataBindings.Add(new Binding("Text", _burger, "Name"));
            TextBox_for_Ingredients.DataBindings.Add(new Binding("Text", _burger, "IngredientsToString"));
        }

        internal void OnClick_EditBurger(object sender, EventArgs e)
        {
                this.Hide();
                Form_EditBurger editBurger = new Form_EditBurger(_burger.Ingredients);
                editBurger.Show();
                _burger.Ingredients = editBurger.ConfirmedIngredients;
                this.Refresh();
        }


    }
}
