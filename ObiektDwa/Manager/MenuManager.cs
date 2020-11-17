﻿using System;
using System.Data;
using System.Linq;

namespace ObiektDwa
{
    internal class MenuManager
    {
        internal Order order;
        public MenuManager()
        {
            order = new Order();
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
            ShowMenu(new MenuService().Menus, true);
            TakeChoiceFromPassedMenu(new MenuService().Menus);
        }

        internal void ShowMenu(Item[] menuItems, bool clear = false)
        {
            Messages.Display("", clear);
            for (int i = 0; i < menuItems.Length; i++)
            {
                Messages.Display($"{i + 1}. {menuItems[i]}");
            }
        }

        internal void TakeChoiceFromPassedMenu(Item[] passedMenu)
        {
            int.TryParse(Console.ReadLine().ToString(), out int chosenNumber);
            if (Enumerable.Range(1, passedMenu.Length).Contains(chosenNumber))
            {
                if (passedMenu[chosenNumber - 1].IsService)
                {
                    RedirectToProperMenu(passedMenu[chosenNumber - 1]);
                }
                else
                {
                    RedirectTo(passedMenu[chosenNumber - 1]);
                }

            }
            else
            {
                Messages.Display("Please take available choice!");
                TakeChoiceFromPassedMenu(passedMenu);
            }

        }

        private void RedirectToProperMenu(Item chosenItem)
        {
            Messages.Display("", true);
            switch (chosenItem.Name)
            {
                case "Take Order":
                case "Order more":
                    TakeOrder();
                    break;
                case "Check, please":
                    CheckPlease();
                    break;
                case "Change the order":
                    //todo Add change order functionality.
                    ChangeOrder();
                    break;
            }
        }

        private void ChangeOrder()
        {
            var changeOrder = order.OrderItems.ToArray();
            Messages.Display("Choose order item you want to make changes to:", true);
            ShowMenu(changeOrder);
            Messages.PressAnyKeyToContinue();
        }

        private void CheckPlease()
        {
            Messages.Display($"Your order is {order.TotalPrice()}", true);
            Messages.PressAnyKeyToContinue();
        }

        private void RedirectTo(Item chosenItem)
        {
            switch (chosenItem.Name)
            {
                case "Burgers":
                    Item[] burgers = new BurgerService().Items;
                    ShowMenu(burgers, true);
                    TakeChoiceFromPassedMenu(burgers);
                    break;
                case "Refreshments":
                    Item[] refreshments = new RefreshmentsService().Items;
                    ShowMenu(refreshments, true);
                    TakeChoiceFromPassedMenu(refreshments);
                    break;
                case "Nothing thanks":
                    if (order.OrderItems.Count == 0)
                    {
                        Messages.PressAnyKeyToContinue("Get out if you're not a customer, please.");
                    }
                    else
                    {
                        Messages.PressAnyKeyToContinue("Good Bye then");
                    }
                    break;
                default:
                    order.AddItem(chosenItem);
                    order.Summary();
                    if (order.IsThatAll())
                    {
                        order.Summary();
                        order.ThankYouForOrder();
                        BeginingOfService();
                    }
                    else 
                    {
                        BeginingOfService();
                    }
                    break;
            }
        }

        internal void BeginingOfService(bool clear = true)
        {
            var beginningOfServiceManager = new Manager.BeginningOfServiceManager();
            beginningOfServiceManager.BeginingOfService(this, clear);
        }
    }
}