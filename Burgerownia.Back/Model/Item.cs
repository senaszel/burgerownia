using System.Collections.Generic;

namespace Burgerownia.Back.Model

{
    public class Item
    {
        private double price;

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get { if (price == default) return TallPrice(); else return price; } set { price = value; } }
        public List<Ingredient> Ingredients { get; set; }

        public bool IsService { get; set; }

        private double TallPrice()
        {
            double sum = 0;
            Ingredients.ForEach(eachIngredient => sum += eachIngredient.Price);
            return sum;
        }

        public Item()
        {
            Ingredients = new List<Ingredient>();
        }

        public Item(string name)
            : this()
        {
            Name = name;
        }

        public Item(string name, double price)
            : this(name)
        {
            Price = price;
        }

        public Item(string name, List<Ingredient> ingredients)
            : this(name)
        {
            ingredients.ForEach(ingredient => this.Ingredients.Add(ingredient));
        }

        public Item(string name, Ingredients ingredients)
            : this(name)
        {
            ingredients.ForEach(ingredient => this.Ingredients.Add(ingredient));
        }

        public Item(int id, string name, Ingredients ingredients)
            : this(name)
        {
            Id = id;
            Ingredients = ingredients;
        }

        public Item(int id, string name, double price)
            : this(name)
        {
            Id = id;
            Price = price;
        }

        public override string ToString() => (Ingredients.Count == 0) ? Name : Name + $"({Ingredients})";


    }
}