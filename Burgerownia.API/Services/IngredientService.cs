using Burgerownia.Back.Interface;
using Burgerownia.Back.Model;
using System.Collections.Generic;
using System.Linq;

namespace Burgerownia.Back.Services
{
    public class IngredientService : IServiceable<Ingredient>
    {
        private IRepository<Ingredient> _ingredientRepository;

        public IngredientService(IRepository<Ingredient> ingredientRepository)
        {
            _ingredientRepository = ingredientRepository;
        }

        public List<Ingredient> Items => _ingredientRepository.GetAll();
        public int ItemsCount => Items.Count;
        public Ingredient GetItemById(int ingredient_id) => Items[ingredient_id];

        public List<Ingredient> GetItemsFromArray(int[] ingredients_ids)
        {
            List<Ingredient> resultsList = new List<Ingredient>();
            ingredients_ids.ToList().ForEach(ingredient_id => resultsList.Add(GetItemById(ingredient_id)));
            return resultsList;
        }
    }
}
