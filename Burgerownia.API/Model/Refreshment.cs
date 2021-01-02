using System.Collections.Generic;

namespace Burgerownia.Back.Model
{
    public class Refreshment : Item
    {
        public Refreshment(string name)
            : base(name)
        {
        }

        public Refreshment(string name, Ingredients ingredients)
            : base(name, ingredients)
        {
        }

        public Refreshment(string name, List<Ingredient> ingredients)
            : base(name, ingredients)
        {
        }
    }
}