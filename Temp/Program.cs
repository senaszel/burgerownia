﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;
using Burgerownia.Back;
using Burgerownia.Back.Interface;
using Burgerownia.Back.Model;

namespace Temp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IContext context = new Context();

            List<Refreshment> items = context.RefreshmentService.Items;

            Type[] extraTypes = new Type[] { typeof(Burger), typeof(Refreshment) };
            var type = items.GetType();
            XmlSerializer serializer = new XmlSerializer(type, extraTypes);
            string dt = DateTime.Now.ToString().Replace('/', '_').Replace(' ', '_').Replace(':', '_');
            Console.WriteLine(Directory.GetCurrentDirectory());
            Console.ReadKey();
            string path =$"{Directory.GetCurrentDirectory()}\\MarekParagon_{dt}.XML";
            StreamWriter sw = new StreamWriter(path);
            serializer.Serialize(sw, items);
            serializer.Serialize(Console.Out, items);
            Console.WriteLine("ok");


            //List<Item> items = new List<Item>();
            //context.BurgerService.Items.ForEach(b => Console.WriteLine(b));
            //context.BurgerService.Items.ForEach(b => items.Add(b as Item));
            //context.RefreshmentService.Items.ForEach(r => items.Add(r as Item));

            //var extraTypes = new Type[] { typeof(Burger), typeof(Refreshment) };
            //var type = items.GetType();
            //XmlSerializer serializer = new XmlSerializer(type, extraTypes);
            //serializer.Serialize(Console.Out, items);




            //context.BurgerService.Items.ForEach(eachBurger => eachBurger.Ingredients.ForEach(p => Console.WriteLine($"{p,50}, {p.Price,15}"))); 
            //Console.WriteLine(context.BurgerService.Items[0]);
            //Console.WriteLine(context.BurgerService.Items[0].Ingredients);
            //Console.WriteLine(  
            //context.BurgerService.Items[0].Name
            //    );
            //Console.WriteLine(
            //context.BurgerService.Items[0].Ingredients.Count
            //    );
            //Console.WriteLine(
            //context.BurgerService.Items[0].Price
            //    );
            //Console.WriteLine();
            //context.BurgerService.Items[0].Ingredients.ForEach(p => Console.WriteLine($"{p,50}, {p.Price,15}")); 

            //context.IngredientService.Items.ForEach(eachIngredient => Console.WriteLine(eachIngredient));
            //Console.WriteLine();
            //context.RefreshmentService.Items.ForEach(eachRefreshment => Console.WriteLine(eachRefreshment));


        }


    }
}
