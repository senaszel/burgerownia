using Burgerownia.Back.Interface;
using Burgerownia.Back.Services;
using System.Collections.Generic;

namespace Burgerownia.Back.Model
{
    public class Ingredients : List<Ingredient>
    {
        private IServiceable<Ingredient> _ingredientService;
        //private List<Ingredient> _listOfIngredients;


        public List<Ingredient> GetAll() => this; //_listOfIngredients;

        public Ingredients(IServiceable<Ingredient> ingredientService,params int[] ingredients)
        {
            _ingredientService = ingredientService;
            this.AddRange(_ingredientService.GetItemsFromArray(ingredients));
        }

        public Ingredients(params Ingredient[] ingredient)
        {
            this.AddRange(ingredient);
        }


        public override string ToString()
        {
            string result = string.Empty;
            ForEach(i =>
            {
                if (i != this[Count - 1])
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