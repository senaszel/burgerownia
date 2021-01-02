using Burgerownia.API.Model;
using System.Collections.Generic;

namespace Burgerownia.API.Repositories
{
    public class BurgerRepository
    {
        private List<Burger> Burgers = new List<Burger>();

        public BurgerRepository()
        {
            AddBurger(new Burger("New Burger", new Ingredients(1, 2, 3)));

            AddBurger(new Burger("Marek Burger", new Ingredients(1)));

            AddBurger(new Burger("Meat Burger",new Ingredients(
                 new Ingredient("meat",8.00),
                 new Ingredient("newIngredient",44.44)
                 )));

            AddBurger(new Burger("Vege Burger", new Ingredients(
                 new Ingredient("vegeMeatsubstitute", 9.50)
                 )));

            AddBurger(new Burger("Burger of a Day", new Ingredients(
                 new Ingredient("day", 100.33)
                 )));

            AddBurger(new Burger("Master Burger", new Ingredients(
                new Ingredient("masterMeat", 1_000_000.00),
                new Ingredient("masterMeat", 1_000_000.00),
                new Ingredient("masterMeat", 1_000_000.00),
                new Ingredient("masterMeat", 1_000_000.00)
                )));
        }


        public void AddBurger(Burger burger)
        {
            if (Burgers.Count != 0)
            {
                burger.Id = Burgers.Count + 1;
                Burgers.Add(burger);
            } else
            {
                burger.Id = 1;
                Burgers.Add(burger);
            }
        }

        public Burger Get(int id) => Burgers.Find(b => b.Id == id);
        
        public List<Burger> GetAll() => Burgers;
    }
}
