using System;

namespace Burgerownia.ConsoleApp.Extensions
{
    public static class StringExtensionMethods
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        public static void Print_Item_That_Is_Selected(this string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        public static void Print_As_Normal_Item(this string text)
        {
            Console.WriteLine(text);
        }


    }
}
