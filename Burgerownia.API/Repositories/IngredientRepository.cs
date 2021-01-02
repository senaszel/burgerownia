using Burgerownia.API.Model;
using System.Collections.Generic;

namespace Burgerownia.API.Repositories
{
    public class IngredientRepository
    {
        public List<Ingredient> Ingredients = new List<Ingredient>()
        {
            new Ingredient(1,"kotlet drobiowy",10.00),
            new Ingredient(2,"kotlet wieprzowy",20.00),
            new Ingredient(3,"salata lodowa",5.00),
            new Ingredient(4,"pomarańcze",6.00),
            new Ingredient(5,"woda gazowana",3.00)
        };

        public List<Ingredient> GetAll() => Ingredients;

    }
}
