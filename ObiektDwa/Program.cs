using System;
using System.Collections.Generic;

namespace ObiektDwa
{
    class Program
    {
        static void Main()
        {
            //var exampleNEW_WAY = new Burger("here", new Ingredients(1, 2, 3).GetAll());
            //var exampleOLDway = new Burger("Vege Burger", new List<Ingredient>() { new Ingredient("vegeMeatsubstitute", 9.50) });

            //Console.WriteLine(exampleNEW_WAY);
            //Console.WriteLine(exampleOLDway);
            //Console.WriteLine("ok");

            MenuManager menu = new MenuManager();
            menu.Welcome();
            menu.BeginingOfService(false);
        }
    }
}
