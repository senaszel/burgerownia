using Burgerownia.Model;
using ObiektDwa;
using System.Collections.Generic;

namespace Burgerownia.API.Repositories
{
    public class BurgerRepository
    {
        private List<Burger> Burgers = new List<Burger>();

        public BurgerRepository()
        {
            AddBurger(new Burger("New Burger", new Ingredients(1, 2, 3).GetAll()));
            AddBurger(new Burger("Marek Burger", new Ingredients(1).GetAll()));
            AddBurger(new Burger(
                        "Meat Burger",
                        new List<Ingredient>() {
                        new Ingredient("meat",8.00),
                        new Ingredient("newIngredient",44.44)
                            }
                        ));
            AddBurger(new Burger("Vege Burger", new List<Ingredient>() { new Ingredient("vegeMeatsubstitute", 9.50) }));
            AddBurger(new Burger("Burger of a Day", new List<Ingredient>() { new Ingredient("day", 100.33) }));
            AddBurger(new Burger("Master Burger", new List<Ingredient>() { new Ingredient("masterMeat", 1_000_000.00) }));
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
