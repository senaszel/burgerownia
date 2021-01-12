using Burgerownia.Back.Interface;
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
    public partial class Form_ChooseIngredient : Form
    {
        public Form_ChooseIngredient(IServiceable<Ingredient> ingredientsService)
        {
            InitializeComponent();

            allPossibleIngredientsListBox.DataSource = ingredientsService.Items;
            allPossibleIngredientsListBox.SelectedIndexChanged += new EventHandler(AddSelectedToPreviousForm);

        }

        public Ingredient IngredientChosenToAdd { get; internal set; }

        private void AddSelectedToPreviousForm(object sender, EventArgs e)
        {
            IngredientChosenToAdd = allPossibleIngredientsListBox.SelectedItem as Ingredient;
            this.Dispose();
        }
    }
}
