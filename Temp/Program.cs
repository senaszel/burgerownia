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
            context.BurgerService.Items.ForEach(eachBurger => Console.WriteLine(eachBurger));
            Console.WriteLine();
            context.IngredientService.Items.ForEach(eachIngredient => Console.WriteLine(eachIngredient));
            Console.WriteLine();
            context.RefreshmentService.Items.ForEach(eachRefreshment => Console.WriteLine(eachRefreshment));


        }


    }
}
