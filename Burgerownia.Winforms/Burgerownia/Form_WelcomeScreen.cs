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
        public Form_WelcomeScreen(IContext context)
        {
            _context = context;
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
            Form_PlaceOrder here = new Form_PlaceOrder(_context);
            here.Show();
        }
    }
}
