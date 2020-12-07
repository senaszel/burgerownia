using ObiektDwa;
using System;
using System.Collections.Generic;
using System.Text;

namespace Burgerownia.API.Repositories
{
public    class BurgerRepository
    {
        private List<Burger> Burgers = new List<Burger>()
        {
                new Burger("New Burger",new Ingredients(1,2,3).GetAll()),
                new Burger("Marek Burger",new Ingredients(1).GetAll()),

                new Burger(
                    "Meat Burger",
                    new List<Ingredient>() {
                        new Ingredient("meat",8.00),
                        new Ingredient("newIngredient",44.44)
                        }
                    ),

                new Burger("Vege Burger",new List<Ingredient>(){ new Ingredient("vegeMeatsubstitute",9.50)}),
                new Burger("Burger of a Day",new List<Ingredient>(){ new Ingredient("day",100.33)}),
                new Burger("Master Burger",new List<Ingredient>(){ new Ingredient("masterMeat",1_000_000.00)})
            };

        public List<Burger> GetAll() => Burgers;
        
    }
}
