using System;
using System.Windows.Forms;
using Burgerownia.Back.Model;

namespace Burgerownia.Winforms
{
    public class Control_MenuPosition_Burger : MenuPositionCustomControl
    {
        private int _pricePercentageModificator;
        private Burger _burger;
        private BindingSource burgerSource;

        public Control_MenuPosition_Burger(Burger burger, (int r, int g, int b) color, int pricePercentageModificator = 100)
            : base(color,burger)
        {
            _pricePercentageModificator = pricePercentageModificator;
            _burger = burger;
            burgerSource = new BindingSource
            {
                DataSource = _burger
            };

            TextBox_Name.DataBindings.Add(new Binding("Text", burgerSource, "Name"));
            TextBox_Price.Text = (_burger.Price * _pricePercentageModificator / 10000).ToString() + " zł";
            if (pricePercentageModificator == 100) AddEventLisnersSpecificToBurgers();
            RefreshIngredientsListBox();
        }

        private void AddEventLisnersSpecificToBurgers()
        {
            Click += new EventHandler(OnClick_EditBurger);
            TextBox_Name.Click += new EventHandler(OnClick_EditBurger);
            TextBox_Price.Click += new EventHandler(OnClick_EditBurger);
            ListBox_for_Ingredients.Click += new EventHandler(OnClick_EditBurger);
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
            TextBox_Price.Text = (_burger.Price * _pricePercentageModificator / 10000).ToString() + " zł";
        }


    }
}
