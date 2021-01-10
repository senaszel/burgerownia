using System;
using System.Collections.Generic;
using System.Text;

namespace Burgerownia.ConsoleApp
{
    public static class DisposableFunctions
    {
        public static void First(object x)
        {
            if (x != null)
            {
                Console.Write(DateTime.Now.ToString());
                Console.ReadKey();
            }
        }

        public static void Second(object x)
        {
            if (x != null)
            {
                Console.Write(x.ToString());
                Console.ReadKey();
            }
        }

        public static void CurrentType(object x)
        {
            if (x != null)
            {
                Console.WriteLine(x.GetType().ToString());
                Console.ReadKey();
            }
        }


    }
}
