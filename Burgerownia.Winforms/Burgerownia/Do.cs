using System.Windows.Forms;

namespace Burgerownia.Winforms
{
    public static class Do
    {
        public static void Not(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }


    }
}
