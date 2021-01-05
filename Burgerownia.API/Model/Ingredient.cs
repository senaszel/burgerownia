using Burgerownia.Back.Enum;
using System.Collections.Generic;

namespace Burgerownia.Back.Model
{
    public class Ingredient : Item
    {
        public bool IsVege { get; set; }
        public bool HasAlergens => Alergens.Count > 0;
        public List<Alergen> Alergens { get; set; }

        public Ingredient(int id, string name, double price)
           : base(name,price)
        {
            Id = id;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}