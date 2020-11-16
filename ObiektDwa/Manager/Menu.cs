using System;
using System.Data;
using System.Linq;

namespace ObiektDwa
{
    internal class Menu
    {
        private Order order;
        public Menu()
        {
            order = new Order();
        }

        internal void Welcome()
        {
            string textMessage = "Hello, welcome to Our Burger Joint.";
            Messages.Display(textMessage);
        }

        internal void TakeOrder()
        {
            Messages.Display("What would you like to order?");
            ShowMenu(new MenuService().Menus);
            TakeChoiceFromMenu(new MenuService().Menus);
        }

        internal void ShowMenu(Item[] menuItems)
        {
            for (int i = 0; i < menuItems.Length; i++)
            {
                Messages.Display($"{i + 1}. {menuItems[i]}");
            }
        }

        private void TakeChoiceFromMenu(Item[] menus, string choice = "")
        {
            if (choice != "")
            {
                string textMessage = $"{choice} has been chosen.";
                Messages.Display(textMessage);
            }

            int.TryParse(Console.ReadLine().ToString(), out int chosenNumber);
            if (Enumerable.Range(1, menus.Length).Contains(chosenNumber))
            {
                RedirectTo(menus[chosenNumber - 1].Name);
            }
            else
            {
                Messages.Display("Please take available choice!");
                TakeChoiceFromMenu(menus);
            }

        }

        private void RedirectTo(string chosenMenu)
        {
            string textMessage = $"DISPLAY MENU = {chosenMenu}";
            Messages.Display(textMessage, true);
            switch (chosenMenu)
            {
                case "Burgers":
                    Item[] burgers = new BurgerService().Items;
                    ShowMenu(burgers);
                    TakeChoiceFromMenu(burgers);
                    break;
                case "Refreshments":
                    Item[] refreshments = new RefreshmentsService().Items;
                    ShowMenu(refreshments);
                    TakeChoiceFromMenu(refreshments);
                    break;
                case "Nothing thanks":
                    if (order.OrderItems.Count == 0)
                    {
                        Messages.Display("Get out if you're not a customer, please.", true);
                    }
                    else
                    {
                        order.ThankYouForOrder();
                    }
                    Messages.PressAnyKeyToContinue();
                    break;
                default:
                    order.AddItem(new Item(chosenMenu));
                    order.Summary();
                    if (order.IsThatAll())
                    {
                        order.Summary();
                        Messages.PressAnyKeyToContinue();
                        order.ThankYouForOrder();
                        Environment.Exit(0);
                    }
                    else
                    {
                        TakeOrder();
                    }
                    break;
            }
        }

    }
}