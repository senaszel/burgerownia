using Burgerownia.Back.Interface;
using Burgerownia.Back.Model;
using Burgerownia.ConsoleApp.Model;
using Burgerownia.DataBase.SQLite;
using System.Collections.Generic;

namespace Burgerownia.ConsoleApp
{
    class MainMenu : Menu, IMenuStart
    {
        internal IDB _db;
        internal IRepository<Ingredient> _ingredientRepository;
        internal IServiceable<Ingredient> _ingredientService;
        internal IRepository<Burger> _burgerRepository;
        internal IServiceable<Burger> _burgerService;
        internal IRepository<Refreshment> _refreshmentRepository;
        internal IServiceable<Refreshment> _refreshmentService;
        
        internal Repositories Repositories;

        internal IOrder order;

        internal delegate MenuItems items();

        public MainMenu(IContext contex,items items)
        {
            _db = contex.Db;
            _ingredientRepository = contex.IngredientRepository;
            _ingredientService = contex.IngredientService;
            _burgerRepository = contex.BurgerRepository;
            _burgerService = contex.BurgerService;
            _refreshmentRepository = contex.RefreshmentRepository;
            _refreshmentService = contex.RefreshmentService;
            order = new Order();

            Repositories = new Repositories(_db);

            Items = items.Invoke();
            Items.Add(new MenuItem() { ItemName= "repo",Function = Repositories.Ingredients})
        }
        

    }
}
