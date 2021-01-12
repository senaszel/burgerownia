﻿using Burgerownia.Back.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Burgerownia.Winforms
{
    public partial class Form_EditBurger : Form
    {
        private List<Ingredient> _ingredientsList;
        public List<Ingredient> ConfirmedIngredients { get; internal set; }

        public Form_EditBurger(List<Ingredient> ingredients)
        {
            InitializeComponent();

            _ingredientsList = ingredients;

            RefreshIngredientsListBox();

            this.button_Add.Click += new EventHandler(this.AddNewIngredient);
            this.button_Delete.Click += new EventHandler(this.DeleteIngredient);
            this.button_Swap.Click += new EventHandler(this.SwapIngredients);
            this.button_Confirm.Click += new EventHandler(this.Confirm);
        }


        private void RefreshIngredientsListBox()
        {
            ingredientsListBox.Items.Clear();
            _ingredientsList.ForEach(ingredient => ingredientsListBox.Items.Add(ingredient));
        }

        private void DeleteIngredient(object sender, EventArgs e)
        {
            _ingredientsList.Remove(ingredientsListBox.SelectedItem as Ingredient);
            RefreshIngredientsListBox();
        }

        private void AddNewIngredient(object sender, EventArgs e)
        {
            Form_ChooseIngredient form_ChooseIngredient = new Form_ChooseIngredient(Program.context.IngredientService);
            form_ChooseIngredient.ShowDialog();
            _ingredientsList.Add(form_ChooseIngredient.IngredientChosenToAdd);
            RefreshIngredientsListBox();
        }

        private void SwapIngredients(object sender, EventArgs e)
        {
            _ingredientsList.Remove(ingredientsListBox.SelectedItem as Ingredient);
            Form_ChooseIngredient form_ChooseIngredient = new Form_ChooseIngredient(Program.context.IngredientService);
            form_ChooseIngredient.ShowDialog();
            _ingredientsList.Add(form_ChooseIngredient.IngredientChosenToAdd);
            RefreshIngredientsListBox();
        }

        private void Confirm(object sender, EventArgs e)
        {
            ConfirmedIngredients = _ingredientsList;
            this.Hide();
        }


    }
}
