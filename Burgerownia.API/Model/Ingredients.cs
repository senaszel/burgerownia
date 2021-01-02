using Burgerownia.API.Services;
using System.Collections.Generic;

namespace Burgerownia.API.Model
{
    public class Ingredients : List<Ingredient>
    {
        private List<Ingredient> _listOfIngredients;
        private IngredientService _service;

        public Ingredients(params int[] ingredient)
        {
            _service = new IngredientService();
            _listOfIngredients = new List<Ingredient>();

            for (int i = 0; i < ingredient.Length; i++)
            {
                _listOfIngredients.Add(
                    _service.GetIngredient(ingredient[i])
                    );
            }
        }

        public Ingredients(params Ingredient[] ingredient)
        {
            _listOfIngredients = new List<Ingredient>();

            for (int i = 0; i < ingredient.Length; i++)
            {
                _listOfIngredients.Add(ingredient[i]);
            }
        }

        public List<Ingredient> GetAll() => _listOfIngredients;

        public override string ToString()
        {
            string result = string.Empty;
            _listOfIngredients.ForEach(i =>
            {
                if (i != _listOfIngredients[_listOfIngredients.Count - 1])
                {
                    result += i;
                    if (i.HasAlergens)
                    {
                        result += "(" + string.Join(',', i.Alergens.ToArray()) + ")";
                    }
                }
                else result += i;
            });

            return result;
        }
    }
}