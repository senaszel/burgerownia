using System;
using System.Collections.Generic;
using System.Text;

namespace ObiektDwa
{
    internal class BurgerService : IServiceable
    {
        public Item[] Items { get => burgers; }
        public int ItemsCount { get => burgers.Length; }

        private Item[] burgers = new Item[]
            {
                new Item("Meat Burger",new List<Ingredient>(){ new Ingredient("meat",8.00)}),
                new Item("Vege Burger",new List<Ingredient>(){ new Ingredient("vegeMeatsubstitute",9.50)}),
                new Item("Burger of a Day",new List<Ingredient>(){ new Ingredient("day",100.33)}),
                new Item("Master Burger",new List<Ingredient>(){ new Ingredient("masterMeat",1_000_000.00)})
            };

        public Item GetItemById(int burgerNumber)
        {
            return Items[burgerNumber];
        }
    }
}
