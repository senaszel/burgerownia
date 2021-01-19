using Burgerownia.Back.Interface;
using Burgerownia.Back.Model;
using Burgerownia.Back.Helpers;
using Burgerownia.Back.Services;
using Burgerownia.DataBase.SQLite;
using System;
using System.Collections.Generic;
using Burgerownia.DataBase.SQLite.Enum;

namespace Burgerownia.Back.Repositories
{
    public class BurgerRepository : IRepository<Burger>
    {
        private IDB _db;
        private IServiceable<Ingredient> _ingredientService;
        private List<Burger> _burgers;

        public BurgerRepository(IDB db, IServiceable<Ingredient> ingredientService)
        {
            _db = db;
            _ingredientService = ingredientService;
            _burgers = new List<Burger>();
            
            GetBurgersFromDB();
            AddIngredients();
        }

        public Burger Get(int id) => _burgers.Find(b => b.Id == id);
        public List<Burger> GetAll() => _burgers;

        private void GetBurgersFromDB()
        {
            string[] _splitted;
            _db.Select(Tables.Burgers)
                .ForEach(eachBurgerInfoFromDB =>
                {
                    _splitted = eachBurgerInfoFromDB.Split(',');

                    _burgers.Add(new Burger(
                        id: Convert.ToInt32(_splitted[0]),
                        name: _splitted[1],
                        ingredients: new Ingredients()
                        ));
                });
        }

        private void AddIngredients()
        {
            _burgers.ForEach(burger =>
            {
                int[] ing = Array.ConvertAll(
                    _db.GetAll_IngredientsIdsOf(burger.Id).Split(',', StringSplitOptions.RemoveEmptyEntries),
                    new Converter<string, int>(ConverterHelper.StringToInt)
                    );
                burger.Ingredients = new Ingredients(_ingredientService, ing);
            });
        }



    }
}

