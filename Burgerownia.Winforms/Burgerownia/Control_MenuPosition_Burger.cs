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

        public Control_MenuPosition_Burger(Burger burger)
            : base()
        {
            ListBox_for_Ingredients.ForeColor = Color.FromArgb(255, 40, 0);

            _burger = burger;
            burgerSource = new BindingSource
            {
                DataSource = _burger
            };

            TextBox_Name.DataBindings.Add(new Binding("Text", burgerSource, "Name"));
            RefreshIngredientsListBox();
        }

        private void Here(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        internal void OnClick_EditBurger(object sender, EventArgs e)
        {
            Form_EditBurger editBurger = new Form_EditBurger(_burger.Ingredients);
            editBurger.ShowDialog();
            RefreshIngredientsListBox();
        }

        private void RefreshIngredientsListBox()
        {
            ListBox_for_Ingredients.Items.Clear();
            _burger.Ingredients.ForEach(ingredient => ListBox_for_Ingredients.Items.Add(ingredient));
        }


    }
}
