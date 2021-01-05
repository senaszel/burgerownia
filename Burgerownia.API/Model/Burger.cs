using System.Collections.Generic;

namespace Burgerownia.Back.Model
{
    public class Burger : Item
    {
        public Burger(int id,string name, Ingredients ingredients)
            : base(id, name, ingredients)
        {
        }


    }
}
