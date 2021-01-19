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
        internal IServiceable<Ingredient> _ingredientService;
        internal IServiceable<Burger> _burgerService;
        internal IServiceable<Refreshment> _refreshmentService;
        
        internal Repositories Repositories;

        internal IOrder order;

        internal delegate MenuItems items();

        public MainMenu(IContext contex,items items)
        {
            _db = contex.Db;
            _ingredientService = contex.IngredientService;
            _burgerService = contex.BurgerService;
            _refreshmentService = contex.RefreshmentService;
            order = new Order();

            Repositories = new Repositories(_db);

            Items = items.Invoke();
            // todo Items.Add(new MenuItem() { ItemName = "repo", Function = Repositories.Ingredients });
        }
        

    }
}
