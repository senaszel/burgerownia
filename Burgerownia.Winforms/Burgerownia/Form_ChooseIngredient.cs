using Burgerownia.Back.Model;
using System;
using System.Windows.Forms;

namespace Burgerownia.Winforms
{
    public partial class Form_ChooseIngredient : Form
    {
        public Ingredient IngredientChosenToAdd { get; internal set; }

        public Form_ChooseIngredient()
        {
            InitializeComponent();

            allPossibleIngredientsListBox.DataSource = Program.context.IngredientService.Items;

            allPossibleIngredientsListBox.SelectedIndexChanged += new EventHandler(AddSelectedToPreviousForm);
        }


        private void AddSelectedToPreviousForm(object sender, EventArgs e)
        {
            IngredientChosenToAdd = allPossibleIngredientsListBox.SelectedItem as Ingredient;
            this.Dispose();
        }


    }
}
