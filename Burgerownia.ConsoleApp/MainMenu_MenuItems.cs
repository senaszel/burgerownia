using Burgerownia.ConsoleApp.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Burgerownia.ConsoleApp
{
    internal class MainMenu_MenuItems : MenuItemsProvider
    {
        public override MenuItems Items()
        {
            MenuItems items = new MenuItems();
            items.Add(MainMenuEnum.TakeOrder.ToString(),null);
            items.Add(MainMenuEnum.Check.ToString(), null);

            return items;
        }


    }
}
