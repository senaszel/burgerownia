using System;
using System.Linq;

using Burgerownia.API.Model;
using Burgerownia.API.Repositories;
using Burgerownia.API.Services;
using Burgerownia.Manager.Messages;

namespace Burgerownia.Manager
{
    internal class MenuManager
    {
        internal IngredientRepository ingredientRepository;
        internal Order order;
        public MenuManager()
        {
            ingredientRepository = new IngredientRepository();
            order = new Order();
        }

        internal void Welcome()
        {
            string textMessage = "Hello, welcome to Our Burger Joint.";
            Message.Display(textMessage);
            textMessage = "How may I serve you?";
            Message.Display(textMessage);
        }

        internal void TakeOrder()
        {
            Message.Display("What would you like to order?");
            Message.Display($"Todays special is : {new Burgerownia.API.Services.BurgerOfADayService().TodaysSpecial()}");
            ShowMenu(new MenuService().Menus, false);
            TakeChoiceFromPassedMenu(new MenuService().Menus);
        }

        internal void ShowMenu(Item[] menuItems, bool clear = false)
        {
            Message.Display("", clear);
            for (int i = 0; i < menuItems.Length; i++)
            {
                Message.Display($"{i + 1}. {menuItems[i]}");
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
                Message.Display("Please take available choice!");
                TakeChoiceFromPassedMenu(passedMenu);
            }

        }

        private void RedirectToProperMenu(Item chosenItem)
        {
            Message.Display("", true);
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
            Message.Display("Choose order item you want to make changes to:", true);
            ShowMenu(changeOrder);
            Message.PressAnyKeyToContinue("Tutaj dodac wybieranie przedmiotu ktory bedzie zmieniony i przeprowadzic operacje :(");
        }

        private void CheckPlease()
        {
            Message.Display($"Your order is {order.TotalPrice()}", true);
            OrderMessage.Summary(order);
            Message.PressAnyKeyToContinue();
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
                        Message.PressAnyKeyToContinue("Get out if you're not a customer, please.");
                    }
                    else
                    {
                        Message.PressAnyKeyToContinue("Good Bye then");
                    }
                    break;
                default:
                    order.AddItem(chosenItem);
                    OrderMessage.Summary(order);
                    if (OrderMessage.IsThatAll())
                    {
                        OrderMessage.Summary(order);
                        OrderMessage.ThankYouForOrder();
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
            var beginningOfServiceManager = new BeginningOfServiceManager();
            beginningOfServiceManager.BeginingOfService(this, clear);
        }
    }
}