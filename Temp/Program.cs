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
            //context.BurgerService.Items.ForEach(eachBurger => eachBurger.Ingredients.ForEach(p => Console.WriteLine($"{p,50}, {p.Price,15}"))); 
            Console.WriteLine(context.BurgerService.Items[0]);
            Console.WriteLine(context.BurgerService.Items[0].Ingredients);
            Console.WriteLine(  
            context.BurgerService.Items[0].Name
                );
            Console.WriteLine(
            context.BurgerService.Items[0].Ingredients.Count
                );
            Console.WriteLine(
            context.BurgerService.Items[0].Price
                );
            Console.WriteLine();
            context.BurgerService.Items[0].Ingredients.ForEach(p => Console.WriteLine($"{p,50}, {p.Price,15}")); 

            //context.IngredientService.Items.ForEach(eachIngredient => Console.WriteLine(eachIngredient));
            //Console.WriteLine();
            //context.RefreshmentService.Items.ForEach(eachRefreshment => Console.WriteLine(eachRefreshment));


        }


    }
}
