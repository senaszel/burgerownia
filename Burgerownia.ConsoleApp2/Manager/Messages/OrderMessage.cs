using Burgerownia.Back.Model;
using System;

namespace Burgerownia.ConsoleApp2.Manager.Messages
{
    public static class OrderMessage
    {
        public static bool IsThatAll()
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
                Message.Display("Please take available choice!");
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

        public static void Summary(IOrder order)
        {
            Message.Display("This is your order: ", true);
            Message.Display("");
            order.Items.ForEach(eachItem => Message.Display($"- {eachItem}"));
        }

        public static void ThankYouForOrder()
        {
            Message.PressAnyKeyToContinue("Thank you for placing order. It will be ready soon.");
        }
    }
}
