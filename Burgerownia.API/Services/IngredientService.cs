using Burgerownia.Back.Model;
using Burgerownia.Back.Repositories;

namespace Burgerownia.Back.Services
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
