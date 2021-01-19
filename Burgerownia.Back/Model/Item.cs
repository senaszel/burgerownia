using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Burgerownia.Back.Model
{
    [Serializable()]
    public class Item : ICloneable
    {
        private double price;

        [XmlIgnore]
        public int Id { get; set; }
        [XmlElement("Name")]
        public string Name { get; set; }
        [XmlElement("Price")]
        public double Price { get { if (price == default) return TallPrice(); else return price; } set { price = value; } }
        [XmlElement("Ingredients")]
        public List<Ingredient> Ingredients { get; set; }
        [XmlIgnore]
        public bool IsService { get; set; }


        public Item() { }

        public Item(string name)
        {
            Ingredients = new List<Ingredient>();
            Name = name;
        }

        /// <summary>
        /// Constructor for Burgers
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="ingredients"></param>
        public Item(int id, string name, Ingredients ingredients)
            : this(name)
        {
            Id = id;
            Ingredients = ingredients;
        }

        /// <summary>
        /// Constructor for Refreshments
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public Item(int id, string name, double price)
            : this(name)
        {
            Id = id;
            Price = price;
        }

        private double TallPrice()
        {
            double sum = 0;
            Ingredients.ForEach(eachIngredient => sum += eachIngredient.Price);
            return sum;
        }

        public override string ToString() => (Ingredients.Count == 0) ? Name : Name + $"({Ingredients})";

        /// <summary>
        /// Method neccessary to pass exact clones of Items to Order List.
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            var clone = MemberwiseClone() as Item;
            clone.Ingredients = new Ingredients(Ingredients.ToArray());
            return clone;
        }

    }
}