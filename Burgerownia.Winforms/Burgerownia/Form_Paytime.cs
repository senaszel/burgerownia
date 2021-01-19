using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Burgerownia.Winforms
{
    public partial class Form_Paytime : Form
    {
        private double total;
        public Form_Paytime()
        {
            this.FormClosing += new FormClosingEventHandler(Do.Close);
            InitializeComponent();

            Program.order.Items.ForEach(i => listBox1.Items.Add(i));
            Program.order.Items.ForEach(i => total += i.Price);
            label1.Text = (total/100).ToString() + " zł";
        }


    }
}
