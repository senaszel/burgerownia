using Burgerownia.Manager;

namespace Burgerownia.ConsoleApp
{
    class Program
    {
        static void Main()
        {
            MenuManager menu = new MenuManager();
            menu.Welcome();
            menu.BeginingOfService(false);


        }
    }
}
