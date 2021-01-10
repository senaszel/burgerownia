using Burgerownia.Back.Interface;
using Burgerownia.Back.Model;

namespace Burgerownia.ConsoleApp
{
    internal class TakeOrder
    {
        internal static void Menu(object obj)
        {
            IRepository<Burger> _burgerRepository = (IRepository<Burger>)obj;
            Message.Display("What would you like to order?");
            Message.Display($"Todays special is : {_burgerRepository.SpecialOfADay()}");
            Message.PressAnyKeyToContinue();
            Menu menu = new Menu();
            menu.Add(new MenuItem() {ItemName="Burgers" });
            menu.Add(new MenuItem() { ItemName = "Refreshments" });
            menu.Add(new MenuItem() { ItemName = "Ingredients" });
            menu.Add(new MenuItem() { ItemName = "Burgers" });
            menu.Start();
        }


    }
}
