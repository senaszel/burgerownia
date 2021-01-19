using System;
using System.Drawing;
using System.Windows.Forms;
using Burgerownia.Back.Model;

namespace Burgerownia.Winforms
{
    public class Control_MenuPosition_Burger : MenuPositionCustomControl
    {
        private int _pricePercentageModificator;
        private Burger _burger;
        private BindingSource burgerSource;

        public Control_MenuPosition_Burger(Burger burger,(int r,int g,int b)color,int pricePercentageModificator = 100)
            : base(color)
        {
            _pricePercentageModificator = pricePercentageModificator;
            _burger = burger;
            burgerSource = new BindingSource
            {
                DataSource = _burger
            };

            TextBox_Name.DataBindings.Add(new Binding("Text", burgerSource, "Name"));
            TextBox_Price.Text = (_burger.Price*_pricePercentageModificator/10000).ToString() + " zł";
            RefreshIngredientsListBox();
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
            TextBox_Price.Text = (_burger.Price*_pricePercentageModificator / 10000).ToString() + " zł";
        }


    }
}
