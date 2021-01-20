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
        public Form_Paytime()
        {
            this.FormClosing += new FormClosingEventHandler(Do.Close);
            InitializeComponent();
        }


    }
}
