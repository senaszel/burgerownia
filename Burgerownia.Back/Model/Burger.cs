﻿namespace Burgerownia.Back.Model
{
    public class Burger : Item
    {
        public Burger() { }

        public Burger(int id, string name, Ingredients ingredients)
            : base(id, name, ingredients) { }


    }
}
