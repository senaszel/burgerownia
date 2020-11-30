using System;
using System.Collections.Generic;

namespace ObiektDwa
{
    class Program
    {
        static void Main()
        {
            var here = new Burger("here", new Ingredients(1, 2, 3).GetAll());
            Console.WriteLine(here.Ingredients.Count);
            //Console.WriteLine("!!!!!!!!!!!");
            //here.Ingredients.ForEach(x => Console.WriteLine(x));
            var dziala = new Burger("Vege Burger", new List<Ingredient>() { new Ingredient("vegeMeatsubstitute", 9.50) });

            Console.WriteLine(here);
            Console.WriteLine(dziala);
            Console.WriteLine("ok");

            //MenuManager menu = new MenuManager();
            //menu.Welcome();
            //menu.BeginingOfService(false);    
        }
    }
}
