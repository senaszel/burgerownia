using System.Collections.Generic;

namespace Burgerownia.API.Model
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
