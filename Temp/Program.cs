using System;
using Burgerownia.Back;
using Burgerownia.Back.Interface;

namespace Temp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IContext context = new Context();
            Console.WriteLine("Ma wypisac cale burgery z calym info");
            context.BurgerService.Items.ForEach(eachBurger => Console.WriteLine(eachBurger));
        }
    }
}
