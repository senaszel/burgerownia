using System;
using System.Linq;

namespace Burgerownia.ConsoleApp
{
    public static class Message
    {
        internal static void Clear() => Console.Clear();
        internal static void Display(string textMessage) => Console.WriteLine(textMessage);
        internal static void Display(params string[] msgs) => msgs.ToList().ForEach(each => Display(each));

        internal static void PressAnyKeyToContinue(string textMessage = "press any key to continue")
        {
            var halfWay = (Console.BufferWidth / 2) - (textMessage.Length / 2);
            Console.WriteLine();
            Console.SetCursorPosition(halfWay, Console.CursorTop);
            Console.WriteLine(textMessage);
            Console.WriteLine();
            Console.ReadKey(true);
        }


    }
}
