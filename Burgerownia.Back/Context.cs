using Burgerownia.Back.Interface;
using Burgerownia.Back.Services;
using Burgerownia.DataBase.SQLite;
using Burgerownia.Back.Repositories;
using Burgerownia.Back.Model;

namespace Burgerownia.Back
{
    public class Context : IContext
    {
        private IDB _database;
        private IRepository<Ingredient> _ingredientRepository;
        private IServiceable<Ingredient> _ingredientService;
        private IRepository<Burger> _burgerRepository;
        private IServiceable<Burger> _burgerService;
        private IRepository<Refreshment> _refreshmentRepository;
        private IServiceable<Refreshment> _refreshmentService;

        public Context()
        {
            _database = new SQLite_DB();
            _ingredientRepository = new IngredientRepository(_database);
            _ingredientService = new IngredientService(_ingredientRepository);
            _refreshmentRepository = new RefreshmentRepository(_database);
            _burgerRepository = new BurgerRepository(_database,_ingredientService);
            _burgerService = new BurgerService(_burgerRepository);
            _refreshmentService = new RefreshmentService(_refreshmentRepository);
        }

        public IDB Db => _database;
        public IRepository<Burger> BurgerRepository => _burgerRepository;
        public IServiceable<Burger> BurgerService => _burgerService;
        public IRepository<Ingredient> IngredientRepository => _ingredientRepository;
        public IServiceable<Ingredient> IngredientService => _ingredientService;
        public IRepository<Refreshment> RefreshmentRepository => _refreshmentRepository;
        public IServiceable<Refreshment> RefreshmentService => _refreshmentService;
    }
}
