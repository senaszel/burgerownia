using Burgerownia.Back.Interface;
using Burgerownia.Back.Model;
using Burgerownia.ConsoleApp.Model;
using Burgerownia.DataBase.SQLite;

namespace Burgerownia.ConsoleApp.Model
{
    class Repositories : IRepo
    {
        private IRepository<Ingredient> ingredientRepository;
        private IRepository<Refreshment> refreshmentRepository;

        public Repositories(IDB db)
        {
            ingredientRepository = new Back.Repositories.IngredientRepository(db);
            refreshmentRepository = new Back.Repositories.RefreshmentRepository(db);
        }

        public IRepository<Ingredient> Ingredients => ingredientRepository;
        public IRepository<Refreshment> Refreshments => refreshmentRepository; 


    }
}
