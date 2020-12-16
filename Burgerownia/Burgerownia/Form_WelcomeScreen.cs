using System;
using System.Windows.Forms;

namespace Burgerownia
{
    public partial class Form_WelcomeScreen : Form
    {
        public Form_WelcomeScreen()
        {
            InitializeComponent();
        }

        private void PictureBox_placeYourOrder_alaButton_Click(object sender, EventArgs e)
        {
            MoveOverToPlaceOrderForm();
        }

        private void pictureBox_logo_Click(object sender, EventArgs e)
        {
            MoveOverToPlaceOrderForm();
        }

        private void MoveOverToPlaceOrderForm()
        {
            this.Hide();
            Form_PlaceOrder dwa = new Form_PlaceOrder();
            dwa.Show();
        }
    }
}
