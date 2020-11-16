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
                new Item("Meat Burger"),
                new Item("Vege Burger"),
                new Item("Burger of a Day"),
                new Item("Master Burger")
            };

        public Item GetItemById(int burgerNumber)
        {
            return Items[burgerNumber];
        }
    }
}
