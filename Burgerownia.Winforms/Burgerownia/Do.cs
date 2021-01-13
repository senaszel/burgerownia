using System;
using System.Windows.Forms;

namespace Burgerownia.Winforms
{
    public static class Do
    {
        public static void Not(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        internal static void Close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
