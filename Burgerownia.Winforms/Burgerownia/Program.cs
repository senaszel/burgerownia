using System;
using System.Windows.Forms;
using Burgerownia.Back.Interface;
using Burgerownia.Back;

namespace Burgerownia
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IContext context = new Context();
            Application.Run(new Form_WelcomeScreen(context));


        }


    }
}
