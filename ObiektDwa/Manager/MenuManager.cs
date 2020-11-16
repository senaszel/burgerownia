using System;
using System.Data;
using System.Linq;

namespace ObiektDwa
{
    internal class MenuManager
    {
        private Order order;
        public MenuManager()
        {
            order = new Order();
        }

        internal void BeginingOfService()
        {
            MenuService menuService = new MenuService();
            if (order.OrderItems.Count != 0)
            {
                menuService.AddToMenu("Services", new Item("Change the order") { IsService = true });
            }
            ShowMenu(menuService.Services);
            TakeChoiceFromMenu(menuService.Services);
        }

        internal void Welcome()
        {
            string textMessage = "Hello, welcome to Our Burger Joint.";
            Messages.Display(textMessage);
            textMessage = "How may I serve you?";
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

        private void TakeChoiceFromMenu(Item[] menuArr)
        {
            int.TryParse(Console.ReadLine().ToString(), out int chosenNumber);
            if (Enumerable.Range(1, menuArr.Length).Contains(chosenNumber))
            {
                if (menuArr[chosenNumber - 1].IsService)
                {
                    //todo
                    RedirectToProperMenu(menuArr[chosenNumber - 1]);
                }
                else
                {
                    RedirectTo(menuArr[chosenNumber - 1]);
                }

            }
            else
            {
                Messages.Display("Please take available choice!");
                TakeChoiceFromMenu(menuArr);
            }

        }

        private void RedirectToProperMenu(Item chosenItem)
        {
            //todo
            switch (chosenItem.Name)
            {
                case "Take Order":
                    TakeOrder();
                    break;
                case "Check, please":
                    CheckPlease();
                    break;
                case "Change the order":
                    //todo Add change order functionality.
                    var changeOrder = order.OrderItems.ToArray();
                    ShowMenu(changeOrder);
                    Messages.PressAnyKeyToContinue();
                    break;
            }
        }

        private void CheckPlease()
        {
            Messages.Display($"Your order is {order.TotalPrice()}", true);
            Messages.PressAnyKeyToContinue();
        }

        private void RedirectTo(Item chosenItem)
        {
            string textMessage = $"DISPLAY MENU = {chosenItem}";
            Messages.Display(textMessage, true);

            switch (chosenItem.Name)
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
                        BeginingOfService();
                    }
                    Messages.PressAnyKeyToContinue();
                    break;
                default:
                    order.AddItem(chosenItem);
                    order.Summary();
                    if (order.IsThatAll())
                    {
                        order.Summary();
                        Messages.PressAnyKeyToContinue();
                        BeginingOfService();
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