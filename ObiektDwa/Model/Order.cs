using System;
using System.Collections.Generic;

namespace ObiektDwa
{
    internal class Order
    {
        public List<Item> OrderItems { get => orderItems; }
        private List<Item> orderItems;

        public Order()
        {
            orderItems = new List<Item>();
        }

        internal void AddItem(Item item)
        {
            OrderItems.Add(item);
        }

        internal void Summary()
        {
            Messages.Display("This is your order: ", true);
            Messages.Display("");
            OrderItems.ForEach(eachItem => Messages.Display($"- {eachItem}"));
        }

        internal bool IsThatAll()
        {
            bool choice = false;

            string textMessage = "Is that all? ( 1 -Yes / 2 -No )";
            var halfWay = (Console.BufferWidth / 2) - (textMessage.Length / 2);
            Console.WriteLine();
            Console.SetCursorPosition(halfWay, Console.CursorTop);
            Console.WriteLine(textMessage);

            int.TryParse(Console.ReadLine().ToString(), out int key);
            if (!(key == 1 || key == 2))
            {
                Messages.Display("Please take available choice!");
                IsThatAll();
            }
            else
            {
                choice = key switch
                {
                    1 => true,
                    2 => false,
                    _ => false
                };
            }

            return choice;
        }

        internal void ThankYouForOrder()
        {
            Messages.Display("Thank you for placing order. It will be ready soon.", true);
        }
    }
}