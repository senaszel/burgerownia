using Burgerownia.NewFolder;
using ObiektDwa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Burgerownia
{
    public partial class Form2 : Form
    {
        private Mati mati;
        public Form2()
        {
            mati = new Mati();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mati.order.AddItem(new Burger("Mario Burger", new Ingredients(1, 2, 3).GetAll()));
            label1.Text = mati.order.OrderItems[0].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mati.order.AddItem(new Burger(
                "Master Burger",
                new List<Ingredient>() {
                    new Ingredient(
                        "masterMeat",
                        1_000_000.00) }
                ));

            label1.Text = mati.order.OrderItems[1].ToString();
        }
    }
}
