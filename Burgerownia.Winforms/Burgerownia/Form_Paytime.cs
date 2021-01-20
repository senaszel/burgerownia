using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Burgerownia.Winforms
{
    public partial class Form_Paytime : Form
    {
        private double totalPrice;
        private List<PictureBox> money;
        public Form_Paytime()
        {
            this.FormClosing += new FormClosingEventHandler(Do.Close);
            InitializeComponent();
            this.pictureBox_back.Click += new EventHandler(BackToPlaceOrder);

            Program.order.Items.ForEach(p => { totalPrice += p.Price; this.listBox_Order.Items.Add(p); });
            this.label_price.Text = (totalPrice / 100).ToString();

            GatherPictureBoxes();
            money.ForEach(m => m.Click += (sender, eventArguments) => PaySome(sender, eventArguments, m.Name));
            this.label_price.TextChanged += (sender, eventArguments) => FinishIfFullyPaid(sender,eventArguments);
        }

        private void BackToPlaceOrder(object sender, EventArgs e)
        {
            Hide();
            Form_PlaceOrder ws = new Form_PlaceOrder();
            ws.Show();
        }

        private void FinishIfFullyPaid(object sender, EventArgs eventArguments)
        {
            if (totalPrice <= 0.0)
            {
                Recipe recipe = new Recipe(Program.order.Items);
                MessageBox.Show("Twoje zamówienie zostało opłacone i jest przygotowywane.","Potwierdzenie",MessageBoxButtons.OK);
                System.Threading.Thread.Sleep(1);
                MessageBox.Show("Drukowanie paragonu","Drukowanie",MessageBoxButtons.OK);
                System.Threading.Thread.Sleep(1);
                MessageBox.Show($"{recipe.Path}", "Ścieżka do paragonu", MessageBoxButtons.OK);
                this.Hide();
                Form_WelcomeScreen ws = new Form_WelcomeScreen();
                ws.Show();
            }
        }

        private void PaySome(object sender, EventArgs e,string name)
        {
            string[] amount = name.Split('_');
            totalPrice -= Convert.ToDouble(amount[1]);
            this.label_price.Text = (totalPrice / 100).ToString();
        }

        private void GatherPictureBoxes()
        {
            money = new List<PictureBox>();
            money.Add(pictureBox_1);
            money.Add(pictureBox_2);
            money.Add(pictureBox_5);
            money.Add(pictureBox_10);
            money.Add(pictureBox_20);
            money.Add(pictureBox_50);
            money.Add(pictureBox_100);
            money.Add(pictureBox_200);
            money.Add(pictureBox_500);
            money.Add(pictureBox_1000);
            money.Add(pictureBox_2000);
            money.Add(pictureBox_5000);
            money.Add(pictureBox_10000);
            money.Add(pictureBox_20000);
            money.Add(pictureBox_50000);
        }
    }
}
