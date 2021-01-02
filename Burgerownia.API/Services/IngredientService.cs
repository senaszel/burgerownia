using Burgerownia.API.Model;
using Burgerownia.API.Repositories;

namespace Burgerownia.API.Services
{
    class IngredientService
    {
        IngredientRepository repo;
        public IngredientService()
        {
            repo = new IngredientRepository();
        }

        public Ingredient GetIngredient(int id) =>
            repo.Ingredients.Find(ingredient => ingredient.Id == id);
    }
}
