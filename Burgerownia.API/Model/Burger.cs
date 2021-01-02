﻿using System.Collections.Generic;

namespace Burgerownia.Back.Model
{
    public class Burger : Item
    {
        public Burger(string name) 
            : base(name)
        {
        }

        public Burger(string name, Ingredients ingredients) 
            : base(name, ingredients)
        {
        }

        public Burger(string name, List<Ingredient> ingredients)
            : base(name, ingredients)
        {
        }
    }
}
