using System;

namespace ObiektDwa
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
