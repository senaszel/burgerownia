using Burgerownia.Back.Enum;
using System.Collections.Generic;

namespace Burgerownia.Back.Model
{
    public class Ingredient : Item
    {
        public bool IsVege { get; set; }
        public bool HasAlergens => Alergens.Count > 0;
        public List<Alergen> Alergens { get; set; }

        public Ingredient(string name, double price)
            : base(name, price)
        {
            Alergens = new List<Alergen>();
        }

        public Ingredient(int id, string name, double price)
            : this(name,price)
        {
            Id = id;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}