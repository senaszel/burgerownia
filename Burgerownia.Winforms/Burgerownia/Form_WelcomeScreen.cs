using Burgerownia.Winforms;
using System;
using System.Windows.Forms;
using Burgerownia.Back.Interface;
using Burgerownia.Back;

namespace Burgerownia
{
    public partial class Form_WelcomeScreen : Form
    {
        IContext _context;
        public Form_WelcomeScreen()
        {
            _context = Program.context;

            InitializeComponent();

            this.pictureBox_logo.Click += new EventHandler(this.MoveOverToPlaceOrderForm);
            this.pictureBox_placeYourOrder_alaButton.Click += new EventHandler(this.MoveOverToPlaceOrderForm);
        }

        private void MoveOverToPlaceOrderForm(object sender, EventArgs e)
        {
            this.Hide();
            Form_PlaceOrder here = new Form_PlaceOrder();
            here.Show();
        }


    }
}
