using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ObiektDwa
{
    public class Burger : Item
    {
        public Burger(string name) 
            : base(name)
        {
        }

        public Burger(string name, List<Ingredient> ingredients) 
            : base(name, ingredients)
        {
        }
    }
}
