using Burgerownia.Back;
using Burgerownia.ConsoleApp.Helpers;

namespace Burgerownia.ConsoleApp
{
    class Program
    {
        static void Main()
        {
            Context injectContext = new Context();
            MainMenu_MenuItems fillMenuWithThese = new MainMenu_MenuItems();
            IMenuStart mainMenu = new MainMenu(injectContext, fillMenuWithThese.Items);
            WelcomeClass.Welcome();
            mainMenu.Start();

        }


    }
}