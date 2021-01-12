using Burgerownia.Back.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Burgerownia.Winforms
{
    public partial class Form_EditBurger : Form
    {
        List<Ingredient> _ingredientsList;
        public Form_EditBurger(List<Ingredient> ingredients)
        {
            InitializeComponent();

            _ingredientsList = ingredients;

            RefreshIngredientsListBox();
            
        }

        private void RefreshIngredientsListBox()
        {
            ingredientsListBox.Items.Clear();
            _ingredientsList.ForEach(ingredient => ingredientsListBox.Items.Add(ingredient));
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            _ingredientsList.Remove(ingredientsListBox.SelectedItem as Ingredient);
            RefreshIngredientsListBox();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Form_ChooseIngredient form_ChooseIngredient = new Form_ChooseIngredient(Program.context.IngredientService);
            form_ChooseIngredient.ShowDialog();
            
        }
    }
}
