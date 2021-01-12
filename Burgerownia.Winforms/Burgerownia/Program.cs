using System;
using System.Windows.Forms;
using Burgerownia.Back.Interface;
using Burgerownia.Back;
using Burgerownia.Winforms;

namespace Burgerownia
{
    static class Program
    {
        internal static IContext context;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            context = new Context();
            Application.Run(new Form_WelcomeScreen());


        }


    }
}
